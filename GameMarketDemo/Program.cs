using GameMarketDemo.Concrete;
using GameMarketDemo.Model;
using System;

namespace GameMarketDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer
            {
                Id = 1,
                Name = "Cagri",
                LName = "Caliskan",
                BirthYear = 1998,
                IdNo = "12345678901"
            };


            Game g1 = new Game
            {
                Id = 1,
                Name = "Squad",
                Publisher = "OffWorld Industries",
                Genre = "First Person Shooter",
                ReleaseDate = 2015,
                Platforms = "PC",
                Price = 80
            };

            SpecialOffer o1 = new SpecialOffer
            {
                Id = 1,
                Type = "percent",
                Name = "25off",
                Value = 25
            };


            SalesManager sale1 = new SalesManager();
            SalesManager sale2 = new SalesManager();

            sale1.MakeSale(c1, g1, null); //özel indirimsiz oyun satışı
            sale2.MakeSale(c1, g1, o1); //özel indirimli satış


            Console.ReadLine();

        }
    }
}
