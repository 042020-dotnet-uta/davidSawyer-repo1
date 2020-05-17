using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class OrderViewModel
    {
        public List<Order> Orders { get; set; }
        public string Stores { get; set; }
        public string Items { get; set; }
        public string Customer { get; set; }
    }
}
