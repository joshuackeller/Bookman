using System;
using Microsoft.EntityFrameworkCore;

namespace Bookman.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Classification> Classification { get; set; }

        protected override void OnModelCreating(ModelBuilder book)
        {
            book.Entity<Classification>().HasData(
                new Classification
                {
                    ClassificationId = 1,
                    ClassificationName = "Fiction"
                },
                new Classification
                {
                    ClassificationId = 2,
                    ClassificationName = "Non-Fiction"
                }
                );

            book.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Classic"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Biography"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Historical"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Self-Help"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Business"
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Thriller"
                },
                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Christian"
                },
                new Category
                {
                    CategoryId = 8,
                    CategoryName = "Health"
                },
                new Category
                {
                    CategoryId = 9,
                    CategoryName = "Action"
                }

                );

            book.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "Les Miserables",
                    Author = "Victor Hugo",
                    Publisher = "Signet",
                    ISBN = "978-0451419439",
                    ClassificationId = 1,
                    CategoryId = 1,
                    Pages = 1488,
                    Price = 995,
                },
                new Book
                {
                    BookId = 2,
                    Title = "Team of Rivals",
                    Author = "Doris Kearns Goodwin",
                    Publisher = "Simon & Schuster",
                    ISBN = "978-0743270755",
                    ClassificationId = 2,
                    CategoryId = 2,
                    Pages = 944,
                    Price = 14.58,
                },
                new Book
                {
                    BookId = 3,
                    Title = "The Snowball",
                    Author = "Alice Schroeder",
                    Publisher = "Bantam",
                    ISBN = "978-0553384611",
                    ClassificationId = 2,
                    CategoryId = 2,
                    Pages = 832,
                    Price = 21.54,
                },
                new Book
                {
                    BookId = 4,
                    Title = "American Ulysses",
                    Author = "Ronald C. White",
                    Publisher = "Random House",
                    ISBN = "978-0812981254",
                    ClassificationId = 2,
                    CategoryId = 2,
                    Pages = 864,
                    Price = 11.61,
                },
                new Book
                {
                    BookId = 5,
                    Title = "Unbroken",
                    Author = "Laura Hillenbrand",
                    Publisher = "Random House",
                    ISBN = "978-0812974492",
                    ClassificationId = 2,
                    CategoryId = 3,
                    Pages = 528,
                    Price = 13.33,
                },
                new Book
                {
                    BookId = 6,
                    Title = "The Great Train Robbery",
                    Author = "Michael Crichton",
                    Publisher = "Random House",
                    ISBN = "978-0804171281",
                    ClassificationId = 1,
                    CategoryId = 3,
                    Pages = 288,
                    Price = 13.33,
                },
                new Book
                {
                    BookId = 7,
                    Title = "Deep Work",
                    Author = "Cal Newport",
                    Publisher = "Vintage",
                    ISBN = "978-1455586691",
                    ClassificationId = 2,
                    CategoryId = 4,
                    Pages = 304,
                    Price = 14.99,
                },
                new Book
                {
                    BookId = 8,
                    Title = "It's Your Ship",
                    Author = "Michael Abrashoff",
                    Publisher = "Grand Central Publishing",
                    ISBN = "978-1455523023",
                    ClassificationId = 2,
                    CategoryId = 4,
                    Pages = 240,
                    Price = 21.66,
                },
                new Book
                {
                    BookId = 9,
                    Title = "The Virgin Way",
                    Author = "Richard Branson",
                    Publisher = "Grand Central Publishing",
                    ISBN = "978-1591847984",
                    ClassificationId = 2,
                    CategoryId = 5,
                    Pages = 400,
                    Price = 29.16,
                },
                new Book
                {
                    BookId = 10,
                    Title = "Sycamore Row",
                    Author = "John Grisham",
                    Publisher = "Batnam",
                    ISBN = "978-0553393613",
                    ClassificationId = 1,
                    CategoryId = 6,
                    Pages = 642,
                    Price = 15.03,
                },
                new Book
                {
                    BookId = 11,
                    Title = "The Way I Heard It",
                    Author = "Mike Rowe",
                    Publisher = "Gallery Books",
                    ISBN = "978-1982131470",
                    ClassificationId = 1,
                    CategoryId = 3,
                    Pages = 272,
                    Price = 12.3,
                },
                new Book
                {
                    BookId = 12,
                    Title = "The Complete Personal Memoirs of Ulysses S. Grant",
                    Author = "Unisses S. Grant",
                    Publisher = "CreateSpace Independent Publishing Platform",
                    ISBN = "978-1481216043",
                    ClassificationId = 2,
                    CategoryId = 2,
                    Pages = 552,
                    Price = 19.99,
                },
                new Book
                {
                    BookId = 13,
                    Title = "The Screwtape Letters",
                    Author = "C.S. Lewis",
                    Publisher = "HarperOne",
                    ISBN = "978-0060652937",
                    ClassificationId = 1,
                    CategoryId = 7,
                    Pages = 209,
                    Price = 10.27,
                },
                new Book
                {
                    BookId = 14,
                    Title = "Sleep Smarter",
                    Author = "Shawn Stevenson",
                    Publisher = "Rodale Books",
                    ISBN = "978-1623367398",
                    ClassificationId = 2,
                    CategoryId = 8,
                    Pages = 288,
                    Price = 17.59,
                },

                new Book
                {
                    BookId = 15,
                    Title = "Titan",
                    Author = "Ron Chernow",
                    Publisher = "Vintage",
                    ISBN = "978-1400077304",
                    ClassificationId = 2,
                    CategoryId = 2,
                    Pages = 832,
                    Price = 16.59,
                },

                new Book
                {
                    BookId = 16,
                    Title = "The Hunt for Red October",
                    Author = "Tom Clancy",
                    Publisher = "Berkley",
                    ISBN = "978-0440001027",
                    ClassificationId = 1,
                    CategoryId = 9,
                    Pages = 656,
                    Price = 9.99,
                }
                );
        }

    }
}
