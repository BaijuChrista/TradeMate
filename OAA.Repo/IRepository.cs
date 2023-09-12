using SC.Data;
using System.Linq;

namespace SC.Repository
{
    public interface IRepository<T> where T : AuditDetail
    {
        IQueryable<T> GetAll();
        T Get(long id);
        IQueryable<T> GetQueryable(long id);
        IQueryable<T> GetQueryable();
        T Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
