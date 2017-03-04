namespace Customer.DTO.Order
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OrderTO : BaseTO<int>
    {
        public int OrderQty { get; set; }
        public int OrderBy { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderMode { get; set; }
        public int OrderModeId { get; set; }
    }
}
