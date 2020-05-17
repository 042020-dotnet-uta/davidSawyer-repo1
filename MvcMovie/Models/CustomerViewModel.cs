using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class CustomerViewModel
    {
        public List<Customer> Customers { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string SearchString { get; set; }
    }
}
