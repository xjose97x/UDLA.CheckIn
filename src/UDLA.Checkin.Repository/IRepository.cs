using UDLA.CheckIn.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace UDLA.Checkin.Repository
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> Add(T entity);
        Task<IEnumerable<T>> Get();
        Task<T> GetById(int id);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
