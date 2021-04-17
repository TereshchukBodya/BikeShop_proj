using BikeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Views
{
    public interface IBikesCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
