using UDLA.Checkin.Repository.Context;
using UDLA.Checkin.Repository.Interfaces;
using UDLA.CheckIn.Data.Entities;

namespace UDLA.Checkin.Repository.Implementations
{
    public class EntryRecordRepository : Repository<EntryRecord>, IEntryRecordRepository
    {
        public EntryRecordRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
