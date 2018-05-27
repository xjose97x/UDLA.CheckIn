using System.ComponentModel.DataAnnotations;

namespace UDLA.CheckIn.WebApi.Dto
{
    public class FacultyDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
