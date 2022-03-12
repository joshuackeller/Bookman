﻿using System;
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

        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }

}
