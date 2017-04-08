

namespace Angular_app.Models.Master
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class Country
    {
        [Key]
        [Required]
        public int CountryId { get; set; }

        [Required]
        [StringLength(25)]
        public string CountryName { get; set; }
    }
}