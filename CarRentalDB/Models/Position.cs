using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB.Models
{
    public class Positions
    {
        public long ID { get; set; }
        public string Name_of_the_position { get; set; }
        public string Requirements { get; set; }
        public string Responsibitities { get; set; }
        public int Salary { get; set; }
        public DbSet<Staff> Employee_Code { get; set; }

    }
}
