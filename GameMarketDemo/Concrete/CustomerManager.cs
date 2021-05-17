using GameMarketDemo.Model;
using GameMarketDemo.Services;
using System;


namespace GameMarketDemo.Concrete
{
    class CustomerManager : ICustomerService
    {
        IUserValidationService userValidationService;

        public CustomerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Customer customer)
        {
            if(userValidationService.Validate(customer) == true)
            {
                Console.WriteLine(customer.Name + " has been added to system.");
            }
            else
            {
                Console.WriteLine("Incorrect user information");
            }
            
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
