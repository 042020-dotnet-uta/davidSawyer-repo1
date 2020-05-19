using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectOneV3.Models;
using System;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class OrderViewModel
    {
        public List<Order> Orders { get; set; }
        public SelectList Locales { get; set; }
        public string Stores { get; set; }
        public DateTime OrderDate { get; set; }
        public string Customer { get; set; }
        public Cart Cart { get; set; }
    }
}
