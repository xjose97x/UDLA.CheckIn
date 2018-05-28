using System.Linq;
using UDLA.CheckIn.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UDLA.Checkin.Repository.Context;
using UDLA.Checkin.Repository.Specifications;

namespace UDLA.Checkin.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly ApplicationDbContext dbContext;

        public Repository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<T> GetById(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public bool TryGetById(int id, out T value)
        {
            value = dbContext.Set<T>().Find(id);
            if (value == null)
            {
                return false;
            }
            dbContext.Entry(value).State = EntityState.Detached;
            return true;
        }

        public async Task<T> GetSingleBySpec(ISpecification<T> spec)
        {
            return (await List(spec)).FirstOrDefault();
        }

        public async Task<IEnumerable<T>> ListAll()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> List(ISpecification<T> spec)
        {
            // fetch a Queryable that includes all expression-based includes
            var queryableResultWithIncludes = spec.Includes
                .Aggregate(dbContext.Set<T>().AsQueryable(),
                    (current, include) => current.Include(include));

            // modify the IQueryable to include any string-based include statements
            var secondaryResult = spec.IncludeStrings
                .Aggregate(queryableResultWithIncludes,
                    (current, include) => current.Include(include));

            // return the result of the query using the specification's criteria expression
            return await secondaryResult
                .Where(spec.Criteria)
                .ToListAsync();
        }

        public async Task<T> Add(T entity)
        {
            dbContext.Set<T>().Add(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
