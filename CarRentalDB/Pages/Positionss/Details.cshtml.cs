using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalDB.Data;
using DB.Models;

namespace CarRentalDB.Pages.Positionss
{
    public class DetailsModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public DetailsModel(CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }

        public Positions Positions { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Positions = await _context.Positions.FirstOrDefaultAsync(m => m.ID == id);

            if (Positions == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
