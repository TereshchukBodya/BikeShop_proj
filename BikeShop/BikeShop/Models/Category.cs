using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string descriptoin { get; set; }
        public List<Bike> Bikes { get; set; }

    }
}
