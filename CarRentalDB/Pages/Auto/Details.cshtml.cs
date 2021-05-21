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
    public class DetailsModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public DetailsModel(CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }

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
    }
}
