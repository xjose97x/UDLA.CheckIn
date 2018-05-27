using System;
using System.ComponentModel.DataAnnotations;

namespace UDLA.CheckIn.WebApi.Dto
{
    public class EntryRecordDto
    {
        public int Id { get; set; }
        [Required]
        public DateTimeOffset DateCreated { get; set; }
        [Required]
        public int EmployeeId { get; set; }
    }
}
