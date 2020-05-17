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
    public class ItemController : Controller
    {
        private readonly MvcMovieContext _context;

        public ItemController(MvcMovieContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            
            IQueryable<string> genreQuery = from m in _context.Items orderby m.Title select m.Title;

            var items = from m in _context.Items select m;

            var itemListVM = new ItemListViewModel
            {
                Items = await items.ToListAsync()
            };

            return View(itemListVM);
        }
    }
}