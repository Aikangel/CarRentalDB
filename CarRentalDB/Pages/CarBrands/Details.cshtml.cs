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
    public class DetailsModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public DetailsModel(CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }

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
    }
}
