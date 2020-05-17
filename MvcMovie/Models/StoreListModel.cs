using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class StoreListModel
    {
        public List<Store> Stores { get; set; }
        public string Name { get; set; }
    }
}
