using UDLA.CheckIn.Data;
using System.Threading.Tasks;
using UDLA.Checkin.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UDLA.Checkin.Repository.Specifications;

namespace UDLA.CheckIn.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IRepository<Employee> employeeRepository;

        public EmployeeController(IRepository<Employee> employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await employeeRepository.ListAll();
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200, Type = typeof(Employee))]
        [ProducesResponseType(404)]
        public IActionResult GetById(int id)
        {
            if (!employeeRepository.TryGetById(id, out var employee))
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpGet("{id:int}/registries")]
        public async Task<IActionResult> GetRegistries(int id)
        {
            var employee = await employeeRepository.GetSingleBySpec(new EmployeeWithRegisterEntriesSpecification(id));
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await employeeRepository.Add(employee);

            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }
    }
}
