using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MvcMovie.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(60,MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }
        
        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        [StringLength(30)]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
