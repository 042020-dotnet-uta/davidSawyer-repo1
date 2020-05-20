using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOneV2.Models
{
    public class Item
    {
        // Item fields
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private decimal _Price;

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        private int _Quantity;

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public Location Location { get; set; }
        List<Item> Items = new List<Item>();
        public virtual ICollection<Order> Orders { get; set; }
        public override String ToString()
        {
            return $"{ID}) {Name} \tPrice: {Price}.00 \tQuantity: {Quantity}";
        }
    }
}
