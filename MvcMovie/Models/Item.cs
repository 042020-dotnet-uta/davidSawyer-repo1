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
    public class Item
    {
        public int Id { get; set; }

        [StringLength(60,MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Store { get; set; }
        public int Quantity { get; set; }

    }
}
