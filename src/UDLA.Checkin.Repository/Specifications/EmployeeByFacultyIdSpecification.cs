using System;
using System.Linq.Expressions;
using UDLA.CheckIn.Data;

namespace UDLA.Checkin.Repository.Specifications
{
    public class EmployeeByFacultyIdSpecification : BaseSpecification<Employee>
    {
        public EmployeeByFacultyIdSpecification(int facultyId) : base(e => e.FacultyId == facultyId)
        {
        }
    }
}
