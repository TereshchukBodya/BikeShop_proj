using BikeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Views.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
