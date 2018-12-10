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
    public class IndexModel : PageModel
    {
        private readonly StockManager.Data.ApplicationDbContext _context;

        public IndexModel(StockManager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Shop> Shop { get;set; }

        public async Task OnGetAsync()
        {
            Shop = await _context.Shop.ToListAsync();
        }
    }
}
