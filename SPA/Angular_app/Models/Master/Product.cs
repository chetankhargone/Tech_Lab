namespace Angular_app.Models.Master
{
    #region Import
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    #endregion

    public class Product
    {
        [Key]
        [Required]
        public int ProdId { get; set; }
        
        [Required]
        [StringLength(25)]
        public string ProdName { get; set; }
    }
}