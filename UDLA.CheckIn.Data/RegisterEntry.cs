using System;
using System.ComponentModel.DataAnnotations;

namespace UDLA.CheckIn.Data
{
    public class RegisterEntry
    {
        [Key]
        public int Id { get; set; }
        public DateTimeOffset DateCreated { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
