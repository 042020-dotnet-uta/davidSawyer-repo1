using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOneV2.Models
{
    public class Customer
	{
		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}

		private string _FName;
		public string FName
		{
			get { return _FName; }
			set { _FName = value; }
		}

		private string _LName;

		public string LName
		{
			get { return _LName; }
			set { _LName = value; }
		}

		private string _UserName;

		public string UserName
		{
			get { return _UserName; }
			set { _UserName = value; }
		}

		private string _Password;

		public string Password
		{
			get { return _Password; }
			set { _Password = value; }
		}
		public virtual ICollection<Order> Orders { get; set; }
	}
}
