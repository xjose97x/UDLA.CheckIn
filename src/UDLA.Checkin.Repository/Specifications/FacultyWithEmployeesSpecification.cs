using System;
using System.Linq.Expressions;
using UDLA.CheckIn.Data;

namespace UDLA.Checkin.Repository.Specifications
{
    public sealed class FacultyWithEmployeesSpecification : BaseSpecification<Faculty>
    {
        public FacultyWithEmployeesSpecification(int id) : base(f => f.Id == id)
        {
            AddInclude(f => f.Employees);
        }

        public FacultyWithEmployeesSpecification() : base(f => true)
        {
            AddInclude(f => f.Employees);
        }
    }
}
