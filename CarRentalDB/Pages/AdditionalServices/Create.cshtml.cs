using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarRentalDB.Data;
using DB.Models;

namespace CarRentalDB.Pages.AdditionalServices
{
    public class CreateModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public CreateModel(CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Additional_services Additional_services { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Additional_services.Add(Additional_services);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
