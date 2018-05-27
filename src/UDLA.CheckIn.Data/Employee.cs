﻿using System.Collections.Generic;

namespace UDLA.CheckIn.Data
{
    public class Employee: Entity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<EntryRecord> EntryRecords { get; set; }

        public Employee(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
    }
}