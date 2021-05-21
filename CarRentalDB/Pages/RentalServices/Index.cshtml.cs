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
    public class IndexModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public IndexModel(CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }

        public IList<Rental_services> Rental_services { get;set; }

        public async Task OnGetAsync()
        {
            Rental_services = await _context.Rental_services.ToListAsync();
        }
    }
}
