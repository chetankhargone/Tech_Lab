using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Repository.Transaction
{
    public interface IDataContext : IDisposable
    {
        void Commit();
        Nullable<int> CommandTimeOut { get; set; }
    }
}
