using BikeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Bike> favBikes { get; set; }
    }
}
