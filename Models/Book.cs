using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Book
    {
        //Set BookId as Key
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        //This only allows xxx-xxxxxxxxxx format
        [Required]
        [RegularExpression(@"^\([0-9]{3})\[-]([0-9]{10})$", ErrorMessage = "ISBN must be 13 digits number")]
        public string ISBN { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public float Price { get; set; }
    }
}
