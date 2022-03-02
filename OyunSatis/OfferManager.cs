using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunSatis
{
    public class OfferManager
    {
        public List<Offer> offers = new List<Offer>();
        public void AddOffer(Offer offer)
        {
            Console.WriteLine(offer.OfferName + " adli kampanya sisteme tanimlandi.");
            offers.Add(offer);
        }
            
        public void UpdateOffer(Offer offer)
        {
            Console.WriteLine(offer.OfferName + " adli kampanya guncellendi.");
        }
        
        public void DeleteOffer(Offer offer)
        {
            Console.WriteLine(offer.OfferName + " adli kampanya silindi.");
        }

        public void ListOffer()
        {

            Console.WriteLine("Special Offers");
            Console.WriteLine("----------------------");
               
            foreach (Offer item in offers)
            {
                Console.WriteLine(item.OfferName);
            }
        }



    }
}
