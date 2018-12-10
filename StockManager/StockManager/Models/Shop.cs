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
        [Key]
        public int ShopUID { get; set; }
        [Required]
        [Display(Name = "Shop Code")]
        [StringLength(10, MinimumLength =2)]
        public string ShopRef { get; set; }
        [Display(Name = "Name")]
        [StringLength(10)]
        [Required]
        public string WarehouseName { get; set; }
        [Display(Name = "Street")]
        [StringLength(60)]
        public string WarehouseStreet { get; set; }
        [Display(Name = "Area")]
        [StringLength(60)]
        public string WarehouseArea { get; set; }
        [Display(Name = "Town")]
        [StringLength(60)]
        public string WarehouseTown { get; set; }
        [Display(Name = "Post Code")]
        [StringLength(11)]
        public string WarehousePostCode { get; set; }
        [Display(Name = "Telephone")]
        [StringLength(16)]
        public string WarehouseTelephone { get; set; }
        [Display(Name = "Fax")]
        [StringLength(16)]    
        public string WarehouseFax { get; set; }
        [Display(Name = "Memo")]
        public string WarehouseMemo { get; set; }
        [Display(Name = "Shop Type")]
        [Required]
        public SHType? SHopType { get; set; }
        public bool DefaultWarehouse { get; set; }
        [Display(Name = "Created By")]
        public int CreatedBy { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

    }
}
