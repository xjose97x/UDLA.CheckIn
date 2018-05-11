using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UDLA.Checkin.Repository;
using UDLA.CheckIn.Data;

namespace UDLA.CheckIn.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IRepository<Employee> employeeRepository;
        private readonly ApplicationDbContext context;

        public EmployeeController(IRepository<Employee> employeeRepository, ApplicationDbContext context)
        {
            this.employeeRepository = employeeRepository;
            this.context = context;
        }

        [HttpGet]
        public IList<Employee> Get()
        {
            var x =context.Employees.Include(employee => employee.RegisterEntries).ToList();
            return x;
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employeeRepository.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            employeeRepository.Add(employee);
        }
    }
}
