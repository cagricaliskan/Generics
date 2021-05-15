using GameMarketDemo.Model;
using GameMarketDemo.Services;
using System;


namespace GameMarketDemo.Concrete
{
    class CustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " has been added to system.");
        }

        public void Update(Customer customer)
        {   
            Console.WriteLine("Informations of " + customer.Name + " has been updated.");
        }

        public void Delete (Customer customer)
        {
            Console.WriteLine("Customer " + customer.Name + " has been deleted from the system.");
        }

    }
}
