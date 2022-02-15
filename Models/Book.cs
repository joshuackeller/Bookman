using System;
using System.ComponentModel.DataAnnotations;

namespace Bookman.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string ISBN { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public int ClassificationId { get; set; }
        public Classification Classification { get; set; }
        [Required]
        public int Pages { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
