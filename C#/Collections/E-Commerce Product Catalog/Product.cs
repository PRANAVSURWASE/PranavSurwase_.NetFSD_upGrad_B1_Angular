using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Product_Catalog
{
    internal class Product
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category {  get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Price:{Price}, Category:{Category}";
        }
    }
}
