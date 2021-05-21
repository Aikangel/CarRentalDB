using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB.Models
{
    public class Car_Brands
    {
        public long ID { get; set; }
        public string Description { get; set; }
        public string Technical_specifications { get; set; }
        public string Name { get; set; }
    }
}
