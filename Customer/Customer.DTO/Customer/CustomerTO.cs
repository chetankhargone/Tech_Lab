namespace ECommerce.DTO.Customer
{
    using Order;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CustomerTO : BaseTO<int>
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string Password { get; set; }
        public string CustomerType { get; set; }
        public int CustomerTypeId { get; set; }
        public List<OrderTO> Orders { get; set; }
    }
}
