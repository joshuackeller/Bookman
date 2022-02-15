using System;
using System.ComponentModel.DataAnnotations;

namespace Bookman.Models
{
    public class Classification
    {
        [Key]
        [Required]
        public int ClassificationId { get; set; }
        public string ClassificationName { get; set; }
    }
}
