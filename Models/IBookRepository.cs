using System;
using System.Linq;

namespace Bookman.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }

        object Select(Func<object, object> p);

        public void SaveBook(Book b);

        public void CreateBook(Book b);

        public void DeleteBook(Book b);
    }
}
