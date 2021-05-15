using GameMarketDemo.Model;

namespace GameMarketDemo.Services
{
    interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
