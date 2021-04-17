using BikeShop.Models;
using BikeShop.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly ApplicationDbContent applicationDbContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(ApplicationDbContent applicationDbContent, ShopCart shopCart)
        {
            this.applicationDbContent = applicationDbContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            applicationDbContent.Order.Add(order);
            var items = shopCart.listShopItems;
            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    BikeID = el.bike.id,
                    orderID = order.id,
                    price = el.bike.price
                };
                applicationDbContent.OrderDetail.Add(orderDetail);
            }

            applicationDbContent.SaveChanges();
        }
    }
}
