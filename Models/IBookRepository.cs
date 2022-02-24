using System;
using System.Linq;

namespace Bookman.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }

        object Select(Func<object, object> p);
    }
}
