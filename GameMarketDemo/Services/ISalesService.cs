using GameMarketDemo.Model;


namespace GameMarketDemo.Services
{
    interface ISalesService
    {
        void MakeSale(Customer customer, Game game, SpecialOffer offer);
    }
}
