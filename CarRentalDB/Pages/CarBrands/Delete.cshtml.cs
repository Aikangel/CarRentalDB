using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalDB.Data;
using DB.Models;

namespace CarRentalDB.Pages.CarBrands
{
    public class DeleteModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public DeleteModel(CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Car_Brands Car_Brands { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Car_Brands = await _context.Car_Brands.FirstOrDefaultAsync(m => m.ID == id);

            if (Car_Brands == null)
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

            Car_Brands = await _context.Car_Brands.FindAsync(id);

            if (Car_Brands != null)
            {
                _context.Car_Brands.Remove(Car_Brands);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
