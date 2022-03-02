using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Bookman.Models
{
    public class EFPurchaseRepository : IPurchaseRepository
    {

        private BookContext context;

        public EFPurchaseRepository(BookContext temp)
        {
            context = temp;
        }

        public IQueryable<Purchase> Purchases => context.Purchase.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SavePurchase(Purchase purchase)
        {
            context.AttachRange(purchase.Lines.Select(x => x.Book));

            if (purchase.PurchaseId == 0)
            {
                context.Purchase.Add(purchase);
            }

            context.SaveChanges();
        }
    }
}
