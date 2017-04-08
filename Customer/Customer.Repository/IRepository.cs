using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ECommerce.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
        IQueryable<T> GetQuery();
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}
