using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class StoreController : Controller
    {
        private readonly MvcMovieContext _context;
        readonly List<Order> Orders = new List<Order>();
        public StoreController(MvcMovieContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            IQueryable<string> genreQuery = from m in _context.Stores orderby m.Name select m.Name;

            var stores = from m in _context.Stores select m;

            var storeVM = new StoreListModel
            {
                Stores = await stores.ToListAsync()
            };

            return View(storeVM);
        }
        //     public IActionResult Inventory()
        //   {
        //     return View();
        //   }
        public IActionResult Inventory(string? test)
        {
            if (test == null)
            {
                return NotFound();
            }

            var store = _context.Stores.Find(test);
            if (store == null)
            {
                return NotFound();
            }
            return View(store);
        }
        public IActionResult StoreHist(string? id)
        {

            // Create and execute raw SQL query.
            string query = "SELECT * FROM Orders where Store = @p0";
            var storeVM = new OrderViewModel
            {
                Stores = _context.Orders.FromSqlRaw(query, id).SingleOrDefault()
            };
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Item not found: ", nameof(id));
            }
            return View(storeVM);
        }
    }
}
