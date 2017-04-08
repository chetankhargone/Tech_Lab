namespace Angular_app.Models
{
    using Angular_app.Models.Master;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;

    public class Customer
    {
        [Key]
        [Required]
        public int CustId { get; set; }

        [Required]
        public string CustName { get; set; }

        [Required]
        public string CustEmail { get; set; }

        [ForeignKey("Country")]
        public Nullable<int> CustCountry { get; set; }

        public virtual Country Country { get; set; }
    }
}