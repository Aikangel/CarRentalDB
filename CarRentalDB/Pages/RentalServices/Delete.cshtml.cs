using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalDB.Data;
using DB.Models;

namespace CarRentalDB.Pages.RentalServices
{
    public class DeleteModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public DeleteModel(CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Rental_services Rental_services { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rental_services = await _context.Rental_services.FirstOrDefaultAsync(m => m.ID == id);

            if (Rental_services == null)
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

            Rental_services = await _context.Rental_services.FindAsync(id);

            if (Rental_services != null)
            {
                _context.Rental_services.Remove(Rental_services);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
