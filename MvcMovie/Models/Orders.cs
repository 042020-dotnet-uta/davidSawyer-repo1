using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string Store { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public string Customer { get; set; }
        public static implicit operator string(Order v)
        {
            throw new NotImplementedException();
        }
    }
}
