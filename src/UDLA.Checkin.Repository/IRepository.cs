using UDLA.CheckIn.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using UDLA.Checkin.Repository.Specifications;

namespace UDLA.Checkin.Repository
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> GetById(int id);
        bool TryGetById(int id, out T value);
        Task<T> GetSingleBySpec(ISpecification<T> spec);
        Task<IEnumerable<T>> ListAll();
        Task<IEnumerable<T>> List(ISpecification<T> spec);
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
