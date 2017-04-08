using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository.Transaction
{
    public interface IUnitOfWork : IDataContext
    {
        void InitTransaction();
        void RollBack();
        void CommitTransaction();
    }
}
