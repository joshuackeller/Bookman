using System;
using System.Linq;

namespace Bookman.Models.ViewModels
{
    public class BooksViewModel
    {
        public IQueryable<Book> Books { get; set; }

         public PageInfo PageInfo {get; set;}
    }
}
