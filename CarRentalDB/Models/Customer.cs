using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB.Models
{
    public class Customers
    {
        public long ID { get; set; }
        public string Full_name { get; set; }
        public int Paul { get; set; }
        public DateTime Date_of_birth { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Passport_details { get; set; }
        public DbSet<Rental_services> Rental_code { get; set; }
    }
}
