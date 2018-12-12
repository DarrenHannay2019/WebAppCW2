using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Models
{
    public class Stock
    {
        public enum SType
        {
            AllSeasons,
            Winter,
            Spring,
            Summer,
            Autumn
        }

        [Key]
        public int StockID { get; set; }

        [Required]
        [Display(Name = "Stock Code")]
        [StringLength(30)]
        public string StockCode { get; set; }

        [Required]
        [Display(Name = "Supplier Reference")]
        public int SupplierRef { get; set; }

        [Required]
        [Display(Name = "Dead Code")]
        public bool DeadCode { get; set; }

        [Required]
        public bool Clearance { get; set; }

        [Required]
        [Display(Name = "Zero Qty")]
        public bool ZeroQty { get; set; }

        [Required]
        public SType Season { get; set; }

        [Required]
        [Display(Name = "Sales Value")]
        public decimal AmtTaken { get; set; }

        [Required]
        [Display(Name = "Qty")]
        public int DeliveredQty { get; set; }

        [Required]
        [Display(Name = "Cost Value")]
        public decimal CostValue { get; set; }

        [Required]
        [Display(Name = "Profit")]
        public decimal PCMarkUp { get; set; }

        [Required]
        [Display(Name = "Created by")]
        public int CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

    }
}
