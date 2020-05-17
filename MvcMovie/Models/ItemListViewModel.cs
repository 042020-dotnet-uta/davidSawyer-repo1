using System.Collections.Generic;

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
