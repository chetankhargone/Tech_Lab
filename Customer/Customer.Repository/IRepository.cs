using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T Add(T entity);
        IEnumerable<T> GetAll();
        IQueryable<T> GetQuery();
        bool Update(T entity);
        bool Delete(T entity);
        void SaveChanges();
    }
}
