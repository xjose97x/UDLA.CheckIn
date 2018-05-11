using System.Collections.Generic;
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
        public IEnumerable<RegisterEntry> Get()
        {
            return registerEntryRepository.GetAll();
        }

        [HttpPost]
        public void Post([FromBody] RegisterEntry registerEntry)
        {
            registerEntryRepository.Add(registerEntry);
        }
    }
}