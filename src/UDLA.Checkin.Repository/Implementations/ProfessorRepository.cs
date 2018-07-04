using UDLA.Checkin.Repository.Context;
using UDLA.Checkin.Repository.Interfaces;
using UDLA.CheckIn.Data.Entities;

namespace UDLA.Checkin.Repository.Implementations
{
    public class ProfessorRepository : Repository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
