using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Models
{
    public class Warehouse
    {
        public enum WHType
        {
            Active,
            Waste,
            Long
        }
        [Key]
        public int WarehouseUID { get; set; }
        [Required]
        [Display(Name ="Warehouse Code")]
        [StringLength(10, MinimumLength = 2)]
        public string WarehouseRef { get; set; }

    }
}
