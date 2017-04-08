using ECommerce.Domain.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain
{
    public class Order : BaseDomain<int>
    {
        public DateTime OrderDate { get; set; }

        public int OrderQty { get; set; }

        public int OrderBy { get; set; }

        public int OrderModeId { get; set; }

        public virtual OrderMode OrderMode { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
