using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"ID:{Id} Name:{Name}";
        }
    }
}
