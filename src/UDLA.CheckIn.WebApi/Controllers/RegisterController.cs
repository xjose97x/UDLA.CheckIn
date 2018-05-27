using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UDLA.Checkin.Repository;
using UDLA.CheckIn.Data;

namespace UDLA.CheckIn.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class RegisterController : Controller
    {
        private readonly IRepository<RegisterEntry> registerEntryRepository;

        public RegisterController(IRepository<RegisterEntry> registerEntryRepository)
        {
            this.registerEntryRepository = registerEntryRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<RegisterEntry>> Get()
        {
            return await registerEntryRepository.ListAll();
        }

        [HttpPost]
        public async Task Post([FromBody] RegisterEntry registerEntry)
        {
            await registerEntryRepository.Add(registerEntry);
        }
    }
}