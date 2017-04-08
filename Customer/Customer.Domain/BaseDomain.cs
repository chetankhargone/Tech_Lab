namespace ECommerce.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class BaseDomain<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
