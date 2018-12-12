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
    public class DetailsModel : PageModel
    {
        private readonly StockManager.Data.ApplicationDbContext _context;

        public DetailsModel(StockManager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public StockManager.Models.Stock Stock { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Stock = await _context.Stock.FirstOrDefaultAsync(m => m.StockID == id);

            if (Stock == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
