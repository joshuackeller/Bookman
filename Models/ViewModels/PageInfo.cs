using System;
namespace Bookman.Models.ViewModels
{
    public class PageInfo
    {
        public double TotalNumBooks { get; set; }

        public double BooksPerPage { get; set; }

        public int CurrentPage { get; set; }

        // Calculate how many total pages are needed
        public int TotalPages => (int) Math.Ceiling((double) TotalNumBooks / BooksPerPage);
    }
}
