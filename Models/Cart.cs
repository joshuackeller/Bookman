using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Bookman.Models
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();

        public virtual void AddItem (Book book, int qty)
        {
            CartLineItem line = Items
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();


            if (line == null)
            {
                Items.Add(new CartLineItem
                {
                    Book = book,
                    Quantity = qty,
                    Price = book.Price,
                });
            }
            else
            {
                line.Quantity += qty;
            }
            
        }

        public virtual void RemoveItem (Book book)
        {
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }

        public virtual void RemoveAllItems()
        {
            Items.Clear();
        }

        public virtual double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Price);

            return sum;
        }


    }

    public class CartLineItem
    {
        [Key]
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

}
