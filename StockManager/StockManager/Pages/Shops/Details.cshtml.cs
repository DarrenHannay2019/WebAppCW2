using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StockManager.Data;
using StockManager.Models;

namespace StockManager.Pages.Shops
{
    public class DetailsModel : PageModel
    {
        private readonly StockManager.Data.ApplicationDbContext _context;

        public DetailsModel(StockManager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Shop Shop { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Shop = await _context.Shop.FirstOrDefaultAsync(m => m.ShopUID == id);

            if (Shop == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
