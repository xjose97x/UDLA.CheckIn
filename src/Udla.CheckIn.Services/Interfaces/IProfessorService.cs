using System.Collections.Generic;
using System.Threading.Tasks;
using UDLA.CheckIn.Data.Entities;

namespace Udla.CheckIn.Services.Interfaces
{
    public interface IProfessorService
    {
        Task CreateNewProfessor(Professor professor);
        Task<IEnumerable<Professor>> Get();
        Task<Professor> GetById(int id);
        Task UpdateProfessor(Professor professor);
        Task RemoveById(int id);
    }
}