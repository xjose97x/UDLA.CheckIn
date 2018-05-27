using AutoMapper;
using Newtonsoft.Json;
using UDLA.Checkin.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using UDLA.Checkin.Repository.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UDLA.CheckIn.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<ApplicationDbContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection"),
                o => o.MigrationsAssembly("UDLA.CheckIn.WebApi")
            ));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services
                .AddMvc()
                .AddXmlSerializerFormatters()
                .AddXmlDataContractSerializerFormatters()
                .AddJsonOptions(o =>
                {
                    o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    o.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                    o.SerializerSettings.Formatting = Formatting.Indented;
                });

            services.AddAutoMapper();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "UDLA CheckIn",
                    Version = "v1",
                    Description = "Web API para registro de tiempos para docentes",
                    Contact = new Contact
                    {
                        Name = "José Escudero", Email = "jose.escudero@udla.edu.ec", Url = "www.udla.edu.ec"
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });
        }
    }
}
