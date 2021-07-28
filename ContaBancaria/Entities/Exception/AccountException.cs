using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Entities.Exception
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {

        }
    }
}
