using UDLA.Checkin.Repository.Context;
using UDLA.Checkin.Repository.Interfaces;
using UDLA.CheckIn.Data.Entities;

namespace UDLA.Checkin.Repository.Implementations
{
    public class FacultyRepository : Repository<Faculty>, IFacultyRepository
    {
        public FacultyRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
