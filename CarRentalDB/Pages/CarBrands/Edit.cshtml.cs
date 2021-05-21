using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRentalDB.Data;
using DB.Models;

namespace CarRentalDB.Pages.CarBrands
{
    public class EditModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public EditModel(CarRentalDB.Data.CarRentalDBContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Car_Brands).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Car_BrandsExists(Car_Brands.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Car_BrandsExists(long id)
        {
            return _context.Car_Brands.Any(e => e.ID == id);
        }
    }
}
