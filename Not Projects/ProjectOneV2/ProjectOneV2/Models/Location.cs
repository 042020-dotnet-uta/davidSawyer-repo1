using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOneV2.Models
{
    public class Location
    {
        // Location fields
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        //List<Licence> Licenses = new List<Licence>();
        public virtual ICollection<Order> Orders { get; set; }
        public Location() { }
    }
}
