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
        [Display(Name = "Shop Name")]
        [Column("ShopName")]
        [StringLength(10)]
        [Required]
        public string WarehouseName { get; set; }
        [Display(Name = "Street")]
        [Column("ShopStreet")]
        [StringLength(60)]
        public string WarehouseStreet { get; set; }
        [Display(Name = "Area")]
        [Column("ShopArea")]
        [StringLength(60)]
        public string WarehouseArea { get; set; }
        [Column("ShopTown")]
        [Display(Name = "Town")]
        [StringLength(60)]
        public string WarehouseTown { get; set; }
        [Column("ShopPostCode")]
        [Display(Name = "Post Code")]
        [StringLength(11)]
        public string WarehousePostCode { get; set; }
        [Column("ShopTelephone")]
        [Display(Name = "Telephone")]
        [StringLength(16)]
        public string WarehouseTelephone { get; set; }
        [Column("ShopFax")]
        [Display(Name = "Fax")]
        [StringLength(16)]    
        public string WarehouseFax { get; set; }
        [Column("ShopMemo")]
        [Display(Name = "Memo")]
        public string WarehouseMemo { get; set; }
        [Display(Name = "Shop Type")]
        [Required]
        public SHType? SHopType { get; set; }
        [Display(Name = "Clearance")]
        [Column("Clearance")]
        public bool DefaultWarehouse { get; set; }
        [Display(Name = "Created By")]
        public int CreatedBy { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

    }
}
