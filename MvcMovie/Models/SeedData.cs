using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Items.Any())
                {
                    return;
                }
                if (!context.Items.Any()) {
                    itemSeed(context);
                }
                static void itemSeed(MvcMovieContext context) { 
                context.Items.AddRange(
                    new Item
                    {
                        Title = "Gadgets and Gizmos",
                        Price = 19.89M,
                        Quantity = 18,
                        Store = "HC Andersen"
                    },

                    new Item
                    {
                        Title = "Whozits and Whatzits",
                        Price = 20.21M,
                        Quantity = 30,
                        Store = "HC Andersen"
                    },

                    new Item
                    {
                        Title = "Thingamabobs",
                        Price = 9.99M,
                        Quantity = 20,
                        Store = "HC Andersen"
                    },
                    new Item
                    {
                        Title = "Gadgets and Gizmos",
                        Price = 19.89M,
                        Quantity = 16,
                        Store = "Musker & Clemonts"
                    },
                    new Item
                    {
                        Title = "Whozits and Whatzits",
                        Price = 20.21M,
                        Quantity = 10,
                        Store = "Musker & Clemonts"
                    },

                    new Item
                    {
                        Title = "Thingamabobs",
                        Price = 9.99M,
                        Quantity = 20,
                        Store = "Musker & Clemonts"
                    },
                    new Item
                    {
                        Title = "Gadgets and Gizmos",
                        Price = 19.89M,
                        Quantity = 9,
                        Store = "Walt D. Inc"
                    },
                    new Item
                    {
                        Title = "Whozits and Whatzits",
                        Price = 20.21M,
                        Quantity = 14,
                        Store = "Walt D. Inc"
                    },

                    new Item
                    {
                        Title = "Thingamabobs",
                        Price = 9.99M,
                        Quantity = 20,
                        Store = "Walt D. Inc"
                    }
                );
                }
                if (context.Customers.Any())
                {
                    return;
                }
                if (!context.Customers.Any())
                {
                    customerSeed(context);
                }
                static void customerSeed(MvcMovieContext context)
                {
                    context.Customers.AddRange(
                        new Customer
                        {
                            FirstName = "Ariel",
                            LastName = "Mermaid",
                            Username = "missquiet",
                            Password = "Part0fYourW0rld"
                        },

                        new Customer
                        {
                            FirstName = "Eric",
                            LastName = "Prince",
                            Username = "antioctopus",
                            Password = "Kisst3hGirl"
                        },

                        new Customer
                        {
                            FirstName = "Ursula",
                            LastName = "SeaWitch",
                            Username = "Vanessa",
                            Password = "p0lypKing"
                        }
                    );
                }
                if (context.Stores.Any())
                {
                    return;
                }
                if (!context.Stores.Any())
                {
                    storeSeed(context);
                }
                static void storeSeed(MvcMovieContext context) { 
                context.Stores.AddRange(
                    new Store
                    {
                        Name = "HC Andersen"
                    },

                    new Store
                    {
                        Name = "Musker & Clemonts"
                    },
                    new Store
                    {
                        Name = "Walt D. Inc"
                    }
                );
                }
                context.SaveChanges();
            }
        }
    }
}
