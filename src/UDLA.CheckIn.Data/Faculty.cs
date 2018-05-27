using System.Collections.Generic;

namespace UDLA.CheckIn.Data
{
    public class Faculty : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

        public Faculty(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
