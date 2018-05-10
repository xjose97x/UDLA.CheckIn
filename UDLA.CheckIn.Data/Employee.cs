using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UDLA.CheckIn.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public IEnumerable<RegisterEntry> RegisterEntries { get; set; }
    }
}
