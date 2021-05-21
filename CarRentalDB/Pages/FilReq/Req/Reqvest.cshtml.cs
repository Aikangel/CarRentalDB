using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarRentalDB.Models;

namespace CarRentalDB.Pages.FilReq.Req
{
    public class ReqvestModel : PageModel
    {
        private readonly CarRentalDB.Data.CarRentalDBContext _context;
        public ReqvestModel (CarRentalDB.Data.CarRentalDBContext context)
        {
            _context = context;
        }
        public IList<Staff> Staff { get; set; } 
    }
}
