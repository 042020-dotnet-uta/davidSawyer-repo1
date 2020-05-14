using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOneV2.Models
{
    public class Order
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        // Order details
        private int _Quantity;

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        private decimal _Price;

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        public Customer Customer { get; set; }

        public Location Location { get; set; }

        public DateTime OrderDate { get; set; }

        public Order() { }

        public Order(Customer Customer, Location Location)
        {
            this.Customer = Customer;
            this.Location = Location;
        }
        public override String ToString()
        {
            return $"{ID}) {Customer} at {Location} \tPrice: {Price} \tQuantity: {Quantity} - ordered {OrderDate}";
        }
    }
}
