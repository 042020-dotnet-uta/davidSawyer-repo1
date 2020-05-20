using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using System.Linq;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var SqLite = new SqliteConnection("Filename=:memory:");
            var DBOptions = new DbContextOptionsBuilder<MvcMovieContext>().UseSqlite(SqLite).Options;
            SqLite.Open();
            using (var db = new MvcMovieContext(DBOptions))
            {
                db.Database.Migrate();
                var clients = new Customer();
                clients.FirstName = "John";
                clients.LastName = "Smith";
                clients.Username = "jsmith";
                clients.Password = "asd123";
                db.Add(clients);
                db.SaveChanges();
            }
            using (var db = new MvcMovieContext(DBOptions))
            {
                var clients = db.Customers
                    .Where(b => b.FirstName == "John")
                    .OrderBy(b => b.Id)
                    .ToList()
                    .First();
                Assert.Equal("John", clients.FirstName);
            }
        }
        [Fact]
        public void Test2()
        {
            var SqLite = new SqliteConnection("Filename=:memory:");
            var DBOptions = new DbContextOptionsBuilder<MvcMovieContext>().UseSqlite(SqLite).Options;
            SqLite.Open();
            using (var db = new MvcMovieContext(DBOptions))
            {
                db.Database.Migrate();
                var clients = new Customer();
                clients.FirstName = "John";
                clients.LastName = "Smith";
                clients.Username = "jsmith";
                clients.Password = "asd123";
                db.Add(clients);
                db.SaveChanges();
            }
            using (var db = new MvcMovieContext(DBOptions))
            {
                var clients = db.Customers
                    .Where(b => b.FirstName == "John")
                    .OrderBy(b => b.Id)
                    .ToList()
                    .First();
                Assert.Equal("Smith", clients.LastName);
            }
        }
        [Fact]
        public void Test3()
        {
            var SqLite = new SqliteConnection("Filename=:memory:");
            var DBOptions = new DbContextOptionsBuilder<MvcMovieContext>().UseSqlite(SqLite).Options;
            SqLite.Open();
            using (var db = new MvcMovieContext(DBOptions))
            {
                db.Database.Migrate();
                var clients = new Customer();
                clients.FirstName = "John";
                clients.LastName = "Smith";
                clients.Username = "jsmith";
                clients.Password = "asd123";
                db.Add(clients);
                db.SaveChanges();
            }
            using (var db = new MvcMovieContext(DBOptions))
            {
                var clients = db.Customers
                    .Where(b => b.FirstName == "John")
                    .OrderBy(b => b.Id)
                    .ToList()
                    .First();
                Assert.Equal("asd123", clients.Password);
            }
        }
        [Fact]
        public void Test4()
        {
            var SqLite = new SqliteConnection("Filename=:memory:");
            var DBOptions = new DbContextOptionsBuilder<MvcMovieContext>().UseSqlite(SqLite).Options;
            SqLite.Open();
            using (var db = new MvcMovieContext(DBOptions))
            {
                db.Database.Migrate();
                var clients = new Customer();
                clients.FirstName = "John";
                clients.LastName = "Smith";
                clients.Username = "jsmith";
                clients.Password = "asd123";
                db.Add(clients);
                db.SaveChanges();
            }
            using (var db = new MvcMovieContext(DBOptions))
            {
                var clients = db.Customers
                    .Where(b => b.FirstName == "John")
                    .OrderBy(b => b.Id)
                    .ToList()
                    .First();
                Assert.Equal("jsmith", clients.Username);
            }
        }
        [Fact]
        public void Test5()
        {
            var SqLite = new SqliteConnection("Filename=:memory:");
            var DBOptions = new DbContextOptionsBuilder<MvcMovieContext>().UseSqlite(SqLite).Options;
            SqLite.Open();
            using (var db = new MvcMovieContext(DBOptions))
            {
                db.Database.Migrate();
                var clients = new Customer();
                clients.FirstName = "John";
                clients.LastName = "Smith";
                clients.Username = "jsmith";
                clients.Password = "asd123";
                db.Add(clients);
                db.SaveChanges();
            }
            using (var db = new MvcMovieContext(DBOptions))
            {
                var clients = db.Customers
                    .Where(b => b.FirstName == "John")
                    .OrderBy(b => b.Id)
                    .ToList()
                    .First();
                Assert.NotEqual("John", clients.LastName);
            }
        }
        [Fact]
        public void Test6()
        {
            var SqLite = new SqliteConnection("Filename=:memory:");
            var DBOptions = new DbContextOptionsBuilder<MvcMovieContext>().UseSqlite(SqLite).Options;
            SqLite.Open();
            using (var db = new MvcMovieContext(DBOptions))
            {
                db.Database.Migrate();
                var clients = new Customer();
                clients.FirstName = "John";
                clients.LastName = "Smith";
                clients.Username = "jsmith";
                clients.Password = "asd123";
                db.Add(clients);
                db.SaveChanges();
            }
            using (var db = new MvcMovieContext(DBOptions))
            {
                var clients = db.Customers
                    .Where(b => b.FirstName == "John")
                    .OrderBy(b => b.Id)
                    .ToList()
                    .First();
                Assert.NotEqual("John", clients.Username);
            }
        }
        [Fact]
        public void Test7()
        {
            var SqLite = new SqliteConnection("Filename=:memory:");
            var DBOptions = new DbContextOptionsBuilder<MvcMovieContext>().UseSqlite(SqLite).Options;
            SqLite.Open();
            using (var db = new MvcMovieContext(DBOptions))
            {
                db.Database.Migrate();
                var clients = new Customer();
                clients.FirstName = "John";
                clients.LastName = "Smith";
                clients.Username = "jsmith";
                clients.Password = "asd123";
                db.Add(clients);
                db.SaveChanges();
            }
            using (var db = new MvcMovieContext(DBOptions))
            {
                var clients = db.Customers
                    .Where(b => b.FirstName == "John")
                    .OrderBy(b => b.Id)
                    .ToList()
                    .First();
                Assert.NotEqual("John", clients.Password);
            }
        }
        [Fact]
        public void Test8()
        {
            var SqLite = new SqliteConnection("Filename=:memory:");
            var DBOptions = new DbContextOptionsBuilder<MvcMovieContext>().UseSqlite(SqLite).Options;
            SqLite.Open();
            using (var db = new MvcMovieContext(DBOptions))
            {
                db.Database.Migrate();
                var clients = new Customer();
                clients.FirstName = "John";
                clients.LastName = "Smith";
                clients.Username = "jsmith";
                clients.Password = "asd123";
                db.Add(clients);
                db.SaveChanges();
            }
            using (var db = new MvcMovieContext(DBOptions))
            {
                var clients = db.Customers
                    .Where(b => b.FirstName == "John")
                    .OrderBy(b => b.Id)
                    .ToList()
                    .First();
                Assert.NotEqual("Smith", clients.FirstName);
            }
        }
        [Fact]
        public void Test9()
        {
            var SqLite = new SqliteConnection("Filename=:memory:");
            var DBOptions = new DbContextOptionsBuilder<MvcMovieContext>().UseSqlite(SqLite).Options;
            SqLite.Open();
            using (var db = new MvcMovieContext(DBOptions))
            {
                db.Database.Migrate();
                var clients = new Order();
                clients.Customer = "John";
                clients.Item1 = 1;
                clients.Item2 = 2;
                clients.Item3 = 3;
                db.Add(clients);
                db.SaveChanges();
            }
            using (var db = new MvcMovieContext(DBOptions))
            {
                var clients = db.Orders
                    .Where(b => b.Customer == "John")
                    .OrderBy(b => b.Id)
                    .ToList()
                    .First();
                Assert.Equal("John", clients.Customer);
            }
        }
        [Fact]
        public void Test10()
        {
            var SqLite = new SqliteConnection("Filename=:memory:");
            var DBOptions = new DbContextOptionsBuilder<MvcMovieContext>().UseSqlite(SqLite).Options;
            SqLite.Open();
            using (var db = new MvcMovieContext(DBOptions))
            {
                db.Database.Migrate();
                var clients = new Item();
                clients.Title = "John";
                clients.Price = 1;
                clients.Quantity = 2;
                clients.Store = "A Store";
                db.Add(clients);
                db.SaveChanges();
            }
            using (var db = new MvcMovieContext(DBOptions))
            {
                var clients = db.Items
                    .Where(b => b.Title == "John")
                    .OrderBy(b => b.Id)
                    .ToList()
                    .First();
                Assert.Equal("John", clients.Title);
            }
        }
        [Fact]
        public void Test11()
        {

        }
        [Fact]
        public void Test12()
        {

        }
        [Fact]
        public void Test13()
        {

        }
        [Fact]
        public void Test14()
        {

        }
        [Fact]
        public void Test15()
        {

        }
        [Fact]
        public void Test16()
        {

        }
        [Fact]
        public void Test17()
        {

        }
        [Fact]
        public void Test18()
        {

        }
        [Fact]
        public void Test19()
        {

        }
        [Fact]
        public void Test20()
        {

        }
    }
}
