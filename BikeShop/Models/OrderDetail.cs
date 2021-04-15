using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int BikeID { get; set; }
        public uint price { get; set; }
        public virtual Bike bike { get; set; }
        public virtual Order order { get; set; }
        
    }
}
