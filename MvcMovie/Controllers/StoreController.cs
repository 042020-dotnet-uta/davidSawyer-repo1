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
        List<Order> Orders = new List<Order>();
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
        public IActionResult Inventory()
        {
            return View();
        }
        public async Task<IActionResult> Inventory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var store = await _context.Stores.FindAsync(id);
            if (store == null)
            {
                return NotFound();
            }
            return View(store);
        }
        public async Task<IActionResult> StoreHist(int? id)
        {

            // Create and execute raw SQL query.
            string query = "SELECT * FROM Orders where Store = @p0";
            var store = await _context.Orders.FromSqlRaw(query, id).SingleOrDefaultAsync();

            return View(store);
        }
    }
}
