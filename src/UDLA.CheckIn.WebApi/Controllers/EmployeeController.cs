using AutoMapper;
using System.Linq;
using UDLA.CheckIn.Data;
using System.Threading.Tasks;
using UDLA.Checkin.Repository;
using UDLA.CheckIn.WebApi.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UDLA.Checkin.Repository.Specifications;
using UDLA.CheckIn.WebApi.Models;

namespace UDLA.CheckIn.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IRepository<Employee> employeeRepository;
        private readonly IMapper mapper;

        public EmployeeController(IRepository<Employee> employeeRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeDto>> Get([FromQuery] PaginationParams pagination)
        {
            return mapper.Map<IEnumerable<EmployeeDto>>(await employeeRepository.ListAll()).Skip(pagination.Offset).Take(pagination.Limit);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200, Type = typeof(EmployeeDto))]
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
        [ProducesResponseType(200, Type = typeof(IEnumerable<EntryRecordDto>))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetRegistries(int id)
        {
            var employee = await employeeRepository.GetSingleBySpec(new EmployeeWithRegisterEntriesSpecification(id));
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<ICollection<EntryRecordDto>>(employee.EntryRecords));
        }

        [HttpPost]
        [ProducesResponseType(201, Type = typeof(EmployeeDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post([FromBody] EmployeeDto employeeDto)
        {
            Employee employee = mapper.Map<Employee>(employeeDto);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await employeeRepository.Add(employee);

            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }

        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public async Task<IActionResult> Put([FromBody] EmployeeDto employeeDto)
        {
            Employee employee = mapper.Map<Employee>(employeeDto);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!employeeRepository.TryGetById(employee.Id, out Employee _))
            {
                return NotFound();
            }
            await employeeRepository.Update(employee);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            if (!employeeRepository.TryGetById(id, out var employee))
            {
                return NotFound();
            }
            await employeeRepository.Delete(employee);
            return NoContent();
        }
    }
}
