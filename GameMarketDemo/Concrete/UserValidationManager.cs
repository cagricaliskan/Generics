using GameMarketDemo.Model;
using GameMarketDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketDemo.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Customer customer)
        {
            if(customer.BirthYear == 1998 && customer.Name == "Cagri" && customer.LName == "Caliskan" && customer.IdNo == "12345678901")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
