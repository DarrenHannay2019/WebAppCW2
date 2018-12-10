using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StockManager.Data;
using StockManager.Models;

namespace StockManager.Pages.Warehouses
{
    public class CreateModel : PageModel
    {
        private readonly StockManager.Data.ApplicationDbContext _context;

        public CreateModel(StockManager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Warehouse Warehouse { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Warehouse.Add(Warehouse);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}