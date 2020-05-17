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
        
        public virtual Locations Locations { get; set; } // get location info
        public virtual Customers Customers { get; set; } // get customer info
        public virtual Items Items { get; set; } // get item info
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public decimal Price { get; set; }
    }
}
