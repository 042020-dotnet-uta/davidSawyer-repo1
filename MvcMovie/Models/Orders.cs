using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjectOneV3.Models;

namespace MvcMovie.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string Store { get; set; }
        //public virtual Store Stores { get; set; }
        public string Item { get; set; }
        //public virtual Item Items { get; set; }
        public string Customer { get; set; }
        public virtual Cart Cart { get; set; } //references the cart object
        public static implicit operator string(Order v)
        {
            throw new NotImplementedException();
        }
        //public virtual Customer Customers { get; set; }
    }
}
