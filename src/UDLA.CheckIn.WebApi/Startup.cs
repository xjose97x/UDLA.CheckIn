using AutoMapper;
using Newtonsoft.Json;
using Udla.CheckIn.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.Extensions.Configuration;
using Udla.CheckIn.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;
using UDLA.Checkin.Repository.Context;
using UDLA.Checkin.Repository.Implementations;
using UDLA.Checkin.Repository.Interfaces;

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
            services.AddDbContextPool<ApplicationDbContext>(options =>
            {
                options.EnableSensitiveDataLogging();
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    o => o.MigrationsAssembly("UDLA.CheckIn.WebApi")
                );
            });

            //Repositories
            services.AddScoped<IEntryRecordRepository, EntryRecordRepository>();
            services.AddScoped<IFacultyRepository, FacultyRepository>();
            services.AddScoped<IProfessorRepository, ProfessorRepository>();
            services.AddScoped<IScheduleRepository, ScheduleRepository>();

            //Services
            services.AddScoped<IEntryRecordService, EntryRecordService>();
            services.AddScoped<IFacultyService, FacultyService>();
            services.AddScoped<IProfessorService, ProfessorService>();
            services.AddScoped<IScheduleService, ScheduleService>();

            services
                .AddCors()
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
            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });
        }
    }
}
