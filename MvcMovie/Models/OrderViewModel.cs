using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class OrderViewModel
    {
        public List<Order> Orders { get; set; }
        public SelectList Locales { get; set; }
        public string Store { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public DateTime OrderDate { get; set; }
        public string Customer { get; set; }
    }
}
