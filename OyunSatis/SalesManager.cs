using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunSatis
{
    class SalesManager
    {
        public void Purchase(Customer customer, Offer offer)
        {
            Console.WriteLine(customer.FirstName+ " oyucusu icin " + offer.OfferName +" kampanyasi ile "+offer.OfferDiscription+" tarifesinden satis gerceklemistir.");
        }
    }
}
