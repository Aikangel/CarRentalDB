using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB.Models
{
    public class Staff
    {
        public long ID { get; set; }
        public string Full_name { get; set; }
        public int Phone { get; set; }
        public string Passport_details { get; set; }
        public string Adress { get; set; }
        public string Paul { get; set; }
        public int Age { get; set; }
        public DbSet<Rental_services> Rental_code { get; set; }
        public DbSet<Cars> Vehicle_code { get; set; }

    }
}
