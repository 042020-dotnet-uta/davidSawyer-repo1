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
    public class Store
    {
        public int Id { get; set; }

        [StringLength(60,MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
    }
}
