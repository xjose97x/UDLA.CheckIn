using System;

namespace UDLA.CheckIn.Data
{
    public class EntryRecord : Entity
    {
        public DateTimeOffset DateCreated { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public EntryRecord(int id, DateTimeOffset dateCreated, int employeeId)
        {
            Id = id;
            DateCreated = dateCreated;
            EmployeeId = employeeId;
        }
    }
}
