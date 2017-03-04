namespace Customer.DTO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BaseTO <T>
    {
        public T Id { get; set; }
    }
}
