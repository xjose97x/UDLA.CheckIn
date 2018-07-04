using System.ComponentModel.DataAnnotations;

namespace UDLA.CheckIn.WebApi.DTOs
{
    public class ProfessorDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public int? FacultyId { get; set; }
    }
}
