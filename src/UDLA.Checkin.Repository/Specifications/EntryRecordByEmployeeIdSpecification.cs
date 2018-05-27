using UDLA.CheckIn.Data;

namespace UDLA.Checkin.Repository.Specifications
{
    public sealed class EntryRecordByEmployeeIdSpecification : BaseSpecification<EntryRecord>
    {
        public EntryRecordByEmployeeIdSpecification(int id) : base(e => e.EmployeeId == id)
        {
        }
    }
}
