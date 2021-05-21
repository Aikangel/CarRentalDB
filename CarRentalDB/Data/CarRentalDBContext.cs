using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DB.Models;

namespace CarRentalDB.Data
{
    public class CarRentalDBContext : DbContext
    {
        public CarRentalDBContext (DbContextOptions<CarRentalDBContext> options)
            : base(options)
        {
        }

        public DbSet<DB.Models.Additional_services> Additional_services { get; set; }

        public DbSet<DB.Models.Cars> Cars { get; set; }

        public DbSet<DB.Models.Car_Brands> Car_Brands { get; set; }

        public DbSet<DB.Models.Customers> Customers { get; set; }

        public DbSet<DB.Models.Positions> Positions { get; set; }

        public DbSet<DB.Models.Rental_services> Rental_services { get; set; }

        public DbSet<DB.Models.Staff> Staff { get; set; }
    }
}
