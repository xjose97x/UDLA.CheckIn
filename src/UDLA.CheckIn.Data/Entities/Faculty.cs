using System.Collections.Generic;

namespace UDLA.CheckIn.Data.Entities
{
    public class Faculty : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Professor> Employees { get; set; }

        public Faculty(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
