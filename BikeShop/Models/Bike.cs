using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class Bike
    {
        public int id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public string image { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public bool available { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}
