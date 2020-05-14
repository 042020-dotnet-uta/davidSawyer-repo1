using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project_One.Models
{
    public class Orders
    {
        public int Id { get; set; }
        // Locations ID
        public Locations Locations;
        // Customer ID
        public Customers Customers;
        // Item ID
        public Items Items;
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public decimal Price { get; set; }
    }
}
