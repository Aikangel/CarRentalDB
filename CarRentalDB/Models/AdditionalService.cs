using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB.Models
{
    public class Additional_services
    {
        public long ID { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public long Service_code_1 { get; set; }
        public long Service_code_2 { get; set; }
        public long Service_code_3 { get; set; }
        public DbSet<Rental_services> Rental_services { get; set; }



    }
}
