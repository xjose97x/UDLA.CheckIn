using System;
using System.ComponentModel.DataAnnotations;

namespace UDLA.CheckIn.WebApi.DTOs
{
    public class EntryRecordDto
    {
        public int Id { get; set; }
        [Required]
        public DateTime? DateCreated { get; set; }
        public int EmployeeId { get; set; }
    }
}
