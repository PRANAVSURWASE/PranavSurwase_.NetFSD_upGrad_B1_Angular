using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal abstract class Sales
    {
        public int DailySales()
        {
            return 400;
        }

        public abstract int MonthlySales();
    }
}
