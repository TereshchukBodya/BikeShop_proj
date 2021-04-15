using BikeShop.Models;
using BikeShop.ViewModels;
using BikeShop.Views;
using BikeShop.Views.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Controllers
{
    public class BikesController : Controller
    {
        private readonly IAllBikes _allBikes;
        private readonly IBikesCategory _allCategories;

        public BikesController(IAllBikes iAllBikes, IBikesCategory ibikesCategory)
        {
            _allBikes = iAllBikes;
            _allCategories = ibikesCategory;
        }

        [Route("Bikes/List")]
        [Route("Bikes/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Bike> bikes = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                bikes = _allBikes.Bikes.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    bikes = _allBikes.Bikes.Where(i => i.Category.categoryName.Equals("Електровелосипеди")).OrderBy(i => i.id);
                    currCategory = "Електровелосипеди";
                }
                else if(string.Equals("standat", category, StringComparison.OrdinalIgnoreCase))
                {
                    bikes = _allBikes.Bikes.Where(i => i.Category.categoryName.Equals("Звичайні велосипеди")).OrderBy(i => i.id);
                    currCategory = "Звичайні велосипеди";
                }

               

               
            }
            var bikeObj = new BikesListViewModel
            {
                allBikes = bikes,
                currCategory = currCategory
            };

            ViewBag.Title = "Сторінка з велосипедами";
           
            return View(bikeObj);
        }
    }
}
