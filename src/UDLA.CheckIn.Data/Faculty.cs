using System.Collections.Generic;

namespace UDLA.CheckIn.Data
{
    public class Faculty : Entity
    {
        public string Nombre { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }

        public Faculty(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
