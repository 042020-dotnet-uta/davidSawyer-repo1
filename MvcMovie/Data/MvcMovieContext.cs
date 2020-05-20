using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        //public MvcMovieContext() { }

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
