using System.Collections.Generic;
using System.Threading.Tasks;
using Udla.CheckIn.Services.Interfaces;
using UDLA.Checkin.Repository.Interfaces;
using UDLA.CheckIn.Data.Entities;

namespace Udla.CheckIn.Services.Implementations
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository professorRepository;

        public ProfessorService(IProfessorRepository professorRepository)
        {
            this.professorRepository = professorRepository;
        }

        public async Task CreateNewProfessor(Professor professor)
        {
            await professorRepository.Add(professor);
        }

        public async Task<IEnumerable<Professor>> Get()
        {
            return await professorRepository.Get();
        }

        public async Task<Professor> GetById(int id)
        {
            return await professorRepository.GetById(id);
        }

        public async Task UpdateProfessor(Professor professor)
        {
            await professorRepository.Update(professor);
        }

        public async Task RemoveById(int id)
        {
            Professor professor = await GetById(id);
            await professorRepository.Delete(professor);
        }
    }
}
