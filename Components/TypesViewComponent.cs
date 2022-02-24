using System;
using Bookman.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Bookman.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private IBookRepository repo;

        public TypesViewComponent (IBookRepository temp )
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["bookCategory"];

            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            return View(types);
        }
    }
}
