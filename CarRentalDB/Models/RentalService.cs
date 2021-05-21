using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB.Models
{
    public class Rental_services
    {
        public long ID { get; set; }
        public DateTime Date_of_issue { get; set; }
        public DateTime Rental_period { get; set; }
        public DateTime Return_Date { get; set; }
        public int Rental_price { get; set; }
        public string Payment_mark { get; set; }


    }
}
