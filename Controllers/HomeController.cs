using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookman.Models;
using Microsoft.EntityFrameworkCore;
using Bookman.Models.ViewModels;

namespace Bookman.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository repo;


        public HomeController(IBookRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Books(string bookCategory, int pageNum = 1)
        {
            var length = 6;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(x => x.Category.CategoryName == bookCategory || bookCategory == null)
                .Include(x => x.Classification)
                .Include(x => x.Category)
                .Skip(length * (pageNum - 1))
                .Take(length),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = (bookCategory == null
                                        ? repo.Books.Count()
                                        : repo.Books.Where(x => x.Category.CategoryName == bookCategory).Count()),
                    BooksPerPage = length,
                    CurrentPage = pageNum
                }

            };
            

            return View(x);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
