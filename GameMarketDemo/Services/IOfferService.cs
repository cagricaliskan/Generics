using GameMarketDemo.Model;


namespace GameMarketDemo.Services
{
    interface IOfferService
    {
        void Add(SpecialOffer offer);
        void Update(SpecialOffer offer);
        void Delete(SpecialOffer offer);
    }
}
