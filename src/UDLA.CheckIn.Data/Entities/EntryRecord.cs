using System;

namespace UDLA.CheckIn.Data.Entities
{
    public class EntryRecord : Entity
    {
        public DateTime DateCreated { get; set; }

        public int EmployeeId { get; set; }
        public virtual Professor Employee { get; set; }

        public EntryRecord(int id, DateTime dateCreated, int employeeId)
        {
            Id = id;
            DateCreated = dateCreated;
            EmployeeId = employeeId;
        }
    }
}
