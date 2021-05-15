using GameMarketDemo.Model;
using GameMarketDemo.Services;
using System;


namespace GameMarketDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " has been added to system.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Informations of " + game.Name + " has been updated.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Customer " + game.Name + " has been deleted from the system.");
        }

    }
}
