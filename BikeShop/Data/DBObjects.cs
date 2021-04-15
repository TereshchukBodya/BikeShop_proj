using BikeShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Data
{
    public class DBObjects
    {
        public static void Initial(ApplicationDbContent content)
        {


            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Bike.Any())
            {
                
                content.AddRange(
                  new Bike { name = "Bulls eBike", title = "", Description = "", image = "/img/Bulls eBike.jpg", price = 24300, isFavourite = true, available = true, Category = Categories["Електровелосипеди"] },
                  new Bike { name = "Cannondale Trail", title = "", Description = "", image = "/img/Cannondale Trail.jpg", price = 17800, isFavourite = true, available = true, Category = Categories["Звичайні велосипеди"] },
                  new Bike { name = "Scott SCALE", title = "", Description = "", image = "/img/Scott SCALE.jpg", price = 15200, isFavourite = false, available = true, Category = Categories["Звичайні велосипеди"] }
                );
            }

            content.SaveChanges();
            
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var List = new Category[]
                    {
                         new Category{categoryName = "Електровелосипеди", descriptoin = "Сучасний вид пересування"  },
                         new Category{categoryName = "Звичайні велосипеди", descriptoin = "На планетарній та перекидній системах перемикання передач" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in List)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
