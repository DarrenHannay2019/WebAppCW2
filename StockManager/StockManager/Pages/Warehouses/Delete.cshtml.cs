using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StockManager.Data;
using StockManager.Models;

namespace StockManager.Pages.Warehouses
{
    public class DeleteModel : PageModel
    {
        private readonly StockManager.Data.ApplicationDbContext _context;

        public DeleteModel(StockManager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Warehouse Warehouse { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Warehouse = await _context.Warehouse.FirstOrDefaultAsync(m => m.WarehouseUID == id);

            if (Warehouse == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Warehouse = await _context.Warehouse.FindAsync(id);

            if (Warehouse != null)
            {
                _context.Warehouse.Remove(Warehouse);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
