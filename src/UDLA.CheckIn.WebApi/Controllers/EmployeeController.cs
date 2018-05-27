using AutoMapper;
using System.Linq;
using UDLA.CheckIn.Data;
using System.Threading.Tasks;
using UDLA.Checkin.Repository;
using UDLA.CheckIn.WebApi.Dto;
using Microsoft.AspNetCore.Mvc;
using UDLA.CheckIn.WebApi.Models;
using System.Collections.Generic;
using UDLA.CheckIn.WebApi.Configuration;
using UDLA.Checkin.Repository.Specifications;

namespace UDLA.CheckIn.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IRepository<Employee> employeeRepository;
        private readonly IRepository<EntryRecord> entryRecordRepository;
        private readonly IMapper mapper;

        public EmployeeController(IRepository<Employee> employeeRepository, IRepository<EntryRecord> entryRecordRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.entryRecordRepository = entryRecordRepository;
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

        [HttpPost]
        [ValidateModel]
        [ProducesResponseType(201, Type = typeof(EmployeeDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post([FromBody] EmployeeDto employeeDto)
        {
            Employee employee = mapper.Map<Employee>(employeeDto);
            await employeeRepository.Add(employee);

            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, mapper.Map<EmployeeDto>(employee));
        }

        [HttpPut]
        [ValidateModel]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public async Task<IActionResult> Put([FromBody] EmployeeDto employeeDto)
        {
            Employee employee = mapper.Map<Employee>(employeeDto);
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

        #region EntryRecords

        [HttpGet("{employeeId:int}/entryrecords")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<EntryRecordDto>))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetEntryRecords(int employeeId)
        {
            var entryRecords = await entryRecordRepository.List(new EntryRecordByEmployeeIdSpecification(employeeId));
            if (entryRecords == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<IEnumerable<EntryRecordDto>>(entryRecords));
        }

        [HttpPost("{employeeId:int}/entryrecords")]
        [ValidateModel]
        public async Task<IActionResult> PostEntryRecord(int employeeId, [FromBody] EntryRecordDto entryRecordDto)
        {
            if (!employeeRepository.TryGetById(employeeId, out Employee _))
            {
                return BadRequest();
            }
            entryRecordDto.EmployeeId = employeeId;
            EntryRecord entryRecord = mapper.Map<EntryRecord>(entryRecordDto);
            await entryRecordRepository.Add(entryRecord);

            return CreatedAtAction(nameof(GetEntryRecordById), new { employeeId = entryRecord.EmployeeId, entryId = entryRecord.Id }, mapper.Map<EntryRecordDto>(entryRecord));
        }

        [HttpGet("{employeeId:int}/entryrecords/{entryId:int}", Name = nameof(GetEntryRecordById))]
        [ProducesResponseType(200, Type = typeof(EntryRecordDto))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetEntryRecordById(int employeeId, int entryId)
        {
            var entryRecords = await entryRecordRepository.List(new EntryRecordByEmployeeIdSpecification(employeeId));
            if (entryRecords == null)
            {
                return NotFound();
            }
            var entry = entryRecords.FirstOrDefault(e => e.Id == entryId);
            if (entry == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<EntryRecordDto>(entry));
        }

        #endregion
    }
}
