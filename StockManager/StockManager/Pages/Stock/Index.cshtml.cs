using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StockManager.Data;
using StockManager.Models;

namespace StockManager.Pages.Stock
{
    public class IndexModel : PageModel
    {
        private readonly StockManager.Data.ApplicationDbContext _context;

        public IndexModel(StockManager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<StockManager.Models.Stock> Stock { get;set; }

        public async Task OnGetAsync()
        {
            Stock = await _context.Stock.ToListAsync();
        }
    }
}
