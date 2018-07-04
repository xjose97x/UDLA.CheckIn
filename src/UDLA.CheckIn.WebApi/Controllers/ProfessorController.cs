using AutoMapper;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Udla.CheckIn.Services.Interfaces;
using UDLA.CheckIn.WebApi.Configuration;
using UDLA.CheckIn.Data.Entities;
using UDLA.CheckIn.WebApi.DTOs;

namespace UDLA.CheckIn.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ProfessorController : Controller
    {
        private readonly IProfessorService professorService;
        private readonly IMapper mapper;

        public ProfessorController(IProfessorService professorService, IMapper mapper)
        {
            this.professorService = professorService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProfessorDto>> Get()
        {
            var professors = await professorService.Get();
            return mapper.Map<IEnumerable<ProfessorDto>>(professors);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200, Type = typeof(ProfessorDto))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetById(int id)
        {

            var professor = await professorService.GetById(id);
            if (professor == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<ProfessorDto>(professor));
        }

        [HttpPost]
        [ValidateModel]
        [ProducesResponseType(201, Type = typeof(ProfessorDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post([FromBody] ProfessorDto professorDto)
        {
            Professor professor = mapper.Map<Professor>(professorDto);
            await professorService.CreateNewProfessor(professor);

            return CreatedAtAction(nameof(GetById), new { id = professor.Id }, mapper.Map<ProfessorDto>(professor));
        }

        [HttpPut]
        [ValidateModel]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public async Task<IActionResult> Put([FromBody] ProfessorDto professorDto)
        {
            Professor professor = mapper.Map<Professor>(professorDto);

            if (await professorService.GetById(professor.Id) == null)
            {
                return NotFound();
            }
            await professorService.UpdateProfessor(professor);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            var professor = await professorService.GetById(id);
            if (professor == null)
            {
                return NotFound();
            }
            await professorService.RemoveById(id);
            return NoContent();
        }

        #region EntryRecords

        #endregion
    }
}
