using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using UDLA.CheckIn.Data;
using UDLA.Checkin.Repository;
using Microsoft.AspNetCore.Mvc;
using UDLA.CheckIn.WebApi.Configuration;
using UDLA.CheckIn.WebApi.Dto;
using UDLA.CheckIn.WebApi.Models;

namespace UDLA.CheckIn.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class FacultyController : Controller
    {
        private readonly IRepository<Faculty> facultyRepository;
        private readonly IMapper mapper;

        public FacultyController(IRepository<Faculty> facultyRepository, IMapper mapper)
        {
            this.facultyRepository = facultyRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<FacultyDto>> Get([FromQuery] PaginationParams pagination)
        {
            return mapper.Map<IEnumerable<FacultyDto>>(await facultyRepository.ListAll()).Skip(pagination.Offset).Take(pagination.Limit);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200, Type = typeof(FacultyDto))]
        [ProducesResponseType(404)]
        public IActionResult GetById(int id)
        {
            if (!facultyRepository.TryGetById(id, out var faculty))
            {
                return NotFound();
            }
            return Ok(faculty);
        }

        [HttpPost]
        [ValidateModel]
        [ProducesResponseType(201, Type = typeof(FacultyDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post([FromBody] FacultyDto facultyDto)
        {
            Faculty faculty = mapper.Map<Faculty>(facultyDto);
            await facultyRepository.Add(faculty);

            return CreatedAtAction(nameof(GetById), new { id = faculty.Id }, mapper.Map<FacultyDto>(faculty));
        }

        [HttpPut]
        [ValidateModel]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public async Task<IActionResult> Put([FromBody] FacultyDto facultyDto)
        {
            Faculty faculty = mapper.Map<Faculty>(facultyDto);
            if (!facultyRepository.TryGetById(faculty.Id, out var _))
            {
                return NotFound();
            }
            await facultyRepository.Update(faculty);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            if (!facultyRepository.TryGetById(id, out var faculty))
            {
                return NotFound();
            }
            await facultyRepository.Delete(faculty);
            return NoContent();
        }
    }
}
