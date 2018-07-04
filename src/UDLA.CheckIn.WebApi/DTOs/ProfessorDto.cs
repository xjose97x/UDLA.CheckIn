using System.ComponentModel.DataAnnotations;

namespace UDLA.CheckIn.WebApi.DTOs
{
    public class ProfessorDto
    {
        public int Id { get; set; }
        [Required]
        public string GivenName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int FacultyId { get; set; }

    }
}
