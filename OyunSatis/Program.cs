using System;

namespace OyunSatis
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Musteri Kaydi
            CustomerService customerService = new CustomerService();
            Customer customer1 = new Customer { FirstName = "Mehmet Akif", Id = 1, LastName = "Ersoy", TcNo = 19949044458, YearOfBirth = 1984 };
            Customer customer2 = new Customer { FirstName = "Mehmet Akif", Id = 2, LastName = "Ersoy", TcNo = 19949044458, YearOfBirth = 1985 };

            customerService.Save(customer1);
            Console.WriteLine("---------------");
            customerService.Save(customer2);
            Console.WriteLine("---------------");

            //Kampamya Kaydi
            OfferManager offerManager = new OfferManager();

            offerManager.AddOffer(new Offer { OfferId = 1, OfferName = "Student Membership", OfferDiscription = "montly fee 9.90" });
            offerManager.AddOffer(new Offer { OfferId = 2, OfferName = "Family Membership", OfferDiscription = "montly fee 19.90" });
            Console.WriteLine("---------------");
            Console.WriteLine("\n");
            offerManager.ListOffer();
            Console.WriteLine("---------------");
            //MernisServiceAdapter mernisServiceAdapter = new MernisServiceAdapter();
            //mernisServiceAdapter.CustomerInfoCheck(new Customer { FirstName = "Mehmet Akif", Id = 2, LastName = "Aksoy", TcNo = 19958044458, YearOfBirth = 1984 });

            //Satis
            SalesManager salesManager = new SalesManager();
            salesManager.Purchase(customer1, offerManager.offers[0]);



        }
    }
}

