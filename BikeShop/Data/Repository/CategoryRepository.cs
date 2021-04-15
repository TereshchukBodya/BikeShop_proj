using BikeShop.Models;
using BikeShop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Data.Repository
{
    public class CategoryRepository : IBikesCategory
    {

        private readonly ApplicationDbContent appDBContent;

        public CategoryRepository(ApplicationDbContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;


    }
}
