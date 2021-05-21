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
    public class IndexModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public IndexModel(CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }

        public IList<Positions> Positions { get;set; }

        public async Task OnGetAsync()
        {
            Positions = await _context.Positions.ToListAsync();
        }
    }
}
