using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB.Models
{
    public class Cars
    {
        public long ID { get; set; }
        public int Registration_number { get; set; }
        public string Return_mark { get; set; }
        public DateTime Date_of_last_maintenance { get; set; }
        public string Special_marks { get; set; }
        public int Rental_day_price { get; set; }
        public int Car_price { get; set; }
        public int Mileage { get; set; }
        public int Body_number { get; set; }
        public int Engine_number { get; set; }
        public DateTime Year_of_release { get; set; }
        public DbSet<Car_Brands> Brand_code { get; set; }
        public DbSet<Rental_services> Rental_code { get; set; }

    }
}