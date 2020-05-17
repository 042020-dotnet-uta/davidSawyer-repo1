using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class OrderController : Controller
    {
        private readonly MvcMovieContext _context;

        public OrderController(MvcMovieContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            
            IQueryable<int> genreQuery = from m in _context.Orders orderby m.Id select m.Id;

            var orders = from m in _context.Orders select m;

            var orderVM = new OrderViewModel
            {
                Orders = await orders.ToListAsync()
            };

            return View(orderVM);
        }
    }
}
