using System;
using System.Linq;

namespace Bookman.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookContext context { get; set; }

        public EFBookRepository (BookContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Book;

        public object Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }

}
