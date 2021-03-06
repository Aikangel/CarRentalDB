using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalDB.Data;
using DB.Models;

namespace CarRentalDB.Pages.Auto
{
    public class DeleteModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public DeleteModel(CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cars Cars { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cars = await _context.Cars.FirstOrDefaultAsync(m => m.ID == id);

            if (Cars == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cars = await _context.Cars.FindAsync(id);

            if (Cars != null)
            {
                _context.Cars.Remove(Cars);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
