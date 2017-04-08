using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Master
{
    public class CustomerType : BaseDomain<int>
    {
        public string TypeName { get; set; }
    }
}
