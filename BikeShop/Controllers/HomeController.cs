using BikeShop.Models;
using BikeShop.ViewModels;
using BikeShop.Views.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Controllers
{
    public class HomeController : Controller
    {
        private  IAllBikes _bikeRep;
        private readonly ShopCart _shopCart;
        public HomeController(IAllBikes bikeRep)
        {
            _bikeRep = bikeRep;
            
        }

        public ViewResult Index()
        {
            var homeBikes = new HomeViewModel 
            { 
                favBikes = _bikeRep.getFavBikes
            };
            return View(homeBikes);
        }

        
    }
}
