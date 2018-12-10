using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Models
{
    public class Shop
    {
        public enum SHType
        {
            Shop,
            Consessions
        }
        public int ShopUID { get; set; }
        [Required]
        [Display(Name = "Shop Code")]
        [StringLength(10, MinimumLength =2)]
        public string ShopRef { get; set; }


    }
}
