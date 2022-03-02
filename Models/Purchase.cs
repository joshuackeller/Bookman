using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Bookman.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }


        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }

        [Required(ErrorMessage ="Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter address line 1.")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter a city.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state.")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a zipcode.")]
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "Please enter a country.")]
        public string Country { get; set; }

    }
}
