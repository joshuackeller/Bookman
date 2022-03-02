using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bookman.Models;
using Bookman.Controllers.Infrastructure;

namespace Bookman.Pages
{
    public class BuyModel : PageModel
    {

        public IBookRepository repo { get; set; }
        public Cart cart { get; set; }
        public string ReturnUrl { get; set; }

        public BuyModel(IBookRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/Page1";
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);
           

            cart.AddItem(b, 1);


            return RedirectToPage(new { ReturnUrl = returnUrl } );
        }

        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            cart.RemoveItem(b);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemoveAll(string returnUrl)
        {
            cart.RemoveAllItems();

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
