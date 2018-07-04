using System.Threading.Tasks;
using UDLA.Checkin.Repository.Context;
using UDLA.CheckIn.Data.Entities;

namespace Udla.CheckIn.Services
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Professor> GetById(int id)
        {
            return await dbContext.Professors.FindAsync(id);
        }
    }
}
