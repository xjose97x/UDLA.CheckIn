using System;

namespace UDLA.CheckIn.Data
{
    public class RegisterEntry : Entity
    {
        public DateTimeOffset DateCreated { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
