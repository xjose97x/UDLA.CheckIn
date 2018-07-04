using UDLA.Checkin.Repository.Context;
using UDLA.Checkin.Repository.Interfaces;
using UDLA.CheckIn.Data.Entities;

namespace UDLA.Checkin.Repository.Implementations
{
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
