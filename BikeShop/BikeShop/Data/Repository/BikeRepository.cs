using BikeShop.Models;
using BikeShop.Views.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Data.Repository
{
    public class BikeRepository : IAllBikes
    {
        private readonly ApplicationDbContent appDBContent;

        public BikeRepository (ApplicationDbContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Bike> Bikes => appDBContent.Bike.Include(c => c.Category);

        public IEnumerable<Bike> getFavBikes => appDBContent.Bike.Where(p => p.isFavourite).Include(c => c.Category);

        public Bike getObjBike(int bikeId) => appDBContent.Bike.FirstOrDefault(p => p.id == bikeId);
        
         
        
    }
}
