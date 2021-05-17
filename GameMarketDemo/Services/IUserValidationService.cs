using GameMarketDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketDemo.Services
{
    interface IUserValidationService
    {
        bool Validate(Customer customer);
    }
}
