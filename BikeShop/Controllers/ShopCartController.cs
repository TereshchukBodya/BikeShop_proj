
using BikeShop.Models;
using BikeShop.ViewModels;
using BikeShop.Views.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllBikes _bikeRep;
        private readonly ShopCart _shopCart;
        public ShopCartController(IAllBikes bikeRep, ShopCart shopCart)
        {
            _bikeRep = bikeRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _bikeRep.Bikes.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
