using GameMarketDemo.Model;
using GameMarketDemo.Services;
using System;


namespace GameMarketDemo.Concrete
{
    class SpecialOfferManager : IOfferService
    {  
        public void Add(SpecialOffer offer)
        {
            Console.WriteLine(offer.Name + " has been added to system.");
        }
           
        public void Update(SpecialOffer offer)
        {
            Console.WriteLine("Information of " + offer.Name +" has been updated.");
        }

        public void Delete(SpecialOffer offer)
        {
            Console.WriteLine(offer.Name + " has been deleted.");
        }
    }
}
