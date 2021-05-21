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
    public class DetailsModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public DetailsModel(CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }

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
    }
}
