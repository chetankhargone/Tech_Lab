using ECommerce.Domain.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain
{
    public class Customer : BaseDomain<int>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int CustType { get; set; }

        public virtual List<Order> Orders { get; set; }

        public virtual CustomerType CustomerType  { get; set; }
    }
}
