using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UDLA.Checkin.Repository;
using UDLA.CheckIn.Data;

namespace UDLA.CheckIn.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class RegisterController : Controller
    {
        private readonly IRepository<Employee> employeeRepository;

        public RegisterController(IRepository<Employee> employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employeeRepository.GetAll();
        }

        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            employeeRepository.Add(employee);
        }
    }
}