using BikeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Views.Interfaces
{
    public interface IAllBikes
    {
        IEnumerable<Bike> Bikes { get; }
        IEnumerable<Bike> getFavBikes { get; }
        Bike getObjBike(int bikeId);

    }
}
