using GameMarketDemo.Model;


namespace GameMarketDemo.Services
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
