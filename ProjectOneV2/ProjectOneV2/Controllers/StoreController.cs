using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using ProjectOneV2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectOneV2.Controllers
{
    public class StoreController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        //
        // GET: /Store/Browse
        public string Browse(string genre)
        {
        
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
            
        }
        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var item = new Item { Name = "Item " + id };
            return View(item);
        }
    }
}
