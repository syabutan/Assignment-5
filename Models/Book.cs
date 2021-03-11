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
        public string AuthorFirstName{ get; set; }
        public string AuthorMiddleName { get; set; }
        [Required]
        public string AuthorLastName{ get; set; }
        [Required]
        public string Publisher { get; set; }
        //This only allows xxx-xxxxxxxxxx format
        [Required]
        [RegularExpression(@"^([0-9]{3})[-]([0-9]{10})$", ErrorMessage = "ISBN must be xxx-xxxxxxxxxx format")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int NumberOfPages { get; set; }

    }
}
