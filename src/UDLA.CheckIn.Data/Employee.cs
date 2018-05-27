using System.Collections.Generic;
using System.Runtime.Serialization;

namespace UDLA.CheckIn.Data
{
    public class Employee: Entity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<RegisterEntry> RegisterEntries { get; set; }
    }
}
