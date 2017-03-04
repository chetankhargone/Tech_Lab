using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain
{
    public class BaseDomain<T>
    {
        public T Id { get; set; }
    }
}
