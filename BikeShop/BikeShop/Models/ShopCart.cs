using BikeShop.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class ShopCart
    {
        private readonly ApplicationDbContent appDBContent;

        public ShopCart(ApplicationDbContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ApplicationDbContent>();
            string ShopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", ShopCartId);

            return new ShopCart(context) { ShopCartId = ShopCartId };
        }

        public void AddToCart(Bike bike)
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                bike = bike,
                price = bike.price
            });
            appDBContent.SaveChanges();

        }

        public List<ShopCartItem> getShopItems()
        {
            return appDBContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.bike).ToList();
        }
    }
}
