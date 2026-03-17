using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class CheckBalanceException:Exception
    {
        public CheckBalanceException(string message) : base(message)
        {
        }
    }
}
