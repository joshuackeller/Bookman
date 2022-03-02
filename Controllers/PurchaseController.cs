using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookman.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bookman.Controllers
{
    public class PurchaseController : Controller
    {
        public IPurchaseRepository repo { get; set; }

        public Cart cart { get; set; }

        public PurchaseController(IPurchaseRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View(new Purchase());
        }
        [HttpPost]
        public IActionResult Index(Purchase purchase)
        {
            if (cart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your basket is empty.");
            }
            if (ModelState.IsValid)
            {
                purchase.Lines = cart.Items.ToArray();
                repo.SavePurchase(purchase);
                cart.RemoveAllItems();

                return RedirectToPage("/PurchaseComplete");
            }
            else
            {
                return View();
            }
        }
    }
}
