using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class ItemListViewModel
    {
        public List<Item> Items { get; set; }
        public decimal Price { get; set; }
        public string Store { get; set; }
        public int Quantity { get; set; }
    }
}
