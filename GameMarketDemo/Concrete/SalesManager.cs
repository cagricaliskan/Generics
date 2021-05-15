using GameMarketDemo.Model;
using GameMarketDemo.Services;
using System;

namespace GameMarketDemo.Concrete
{
    class SalesManager : ISalesService
    {
        public void MakeSale(Customer customer, Game game, SpecialOffer offer)
        {   
            if(offer != null)
            {
                int dsc = (game.Price * offer.Value) / 100;
                int newPrice = game.Price - dsc;

                Console.WriteLine(game.Name + " has been bought by " + customer.Name + " with special offer -" + offer.Name + "-. Total cost : " + newPrice + "TL");
            }
            else
            {
                Console.WriteLine(game.Name + " has been bought by " + customer.Name + ". Total cost : " + game.Price + "TL");
            }
            
        }
    }
}
