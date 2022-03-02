using System;
using System.Linq;

namespace Bookman.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get; }

        void SavePurchase(Purchase purchase);
       
    }
}
