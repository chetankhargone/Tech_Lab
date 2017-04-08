using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Master
{
    public class OrderMode : BaseDomain<int>
    {
        public string ModeName { get; set; }
    }
}
