using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class OrderViewModel
    {
        public List<Order> Orders { get; set; }
        public List<Store> Stores { get; set; }
        public List<Item> Items { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
