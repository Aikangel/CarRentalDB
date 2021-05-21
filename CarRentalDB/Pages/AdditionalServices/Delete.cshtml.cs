using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalDB.Data;
using DB.Models;

namespace CarRentalDB.Pages.AdditionalServices
{
    public class DeleteModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public DeleteModel(CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Additional_services Additional_services { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Additional_services = await _context.Additional_services.FirstOrDefaultAsync(m => m.ID == id);

            if (Additional_services == null)
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

            Additional_services = await _context.Additional_services.FindAsync(id);

            if (Additional_services != null)
            {
                _context.Additional_services.Remove(Additional_services);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
