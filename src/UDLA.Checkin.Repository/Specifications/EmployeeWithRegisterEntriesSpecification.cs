﻿using UDLA.CheckIn.Data;

namespace UDLA.Checkin.Repository.Specifications
{
    public sealed class EmployeeWithRegisterEntriesSpecification : BaseSpecification<Employee>
    {
        public EmployeeWithRegisterEntriesSpecification(int id) : base(e => e.Id == id)
        {
            AddInclude(e => e.RegisterEntries);
        }

        public EmployeeWithRegisterEntriesSpecification() : base(e => true)
        {
            AddInclude(e => e.RegisterEntries);
        }
    }
}
