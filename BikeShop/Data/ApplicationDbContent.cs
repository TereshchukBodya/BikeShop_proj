using BikeShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop.Data
{
    public class ApplicationDbContent : DbContext
    {
        public ApplicationDbContent(DbContextOptions<ApplicationDbContent> options) : base(options)
        {

        }

        public DbSet<Bike> Bike { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }


    }
}
