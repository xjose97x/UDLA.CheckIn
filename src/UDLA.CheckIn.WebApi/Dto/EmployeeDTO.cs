using System.ComponentModel.DataAnnotations;

namespace UDLA.CheckIn.WebApi.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public int? FacultyId { get; set; }
    }
}
