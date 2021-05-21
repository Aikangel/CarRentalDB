using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalDB.Data;
using DB.Models;

namespace CarRentalDB.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;

        public IndexModel(CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
