using BikeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.ViewModels
{
    public class BikesListViewModel
    {
        public IEnumerable<Bike> allBikes { get; set; }
        public string currCategory { get; set; }
    }
}
