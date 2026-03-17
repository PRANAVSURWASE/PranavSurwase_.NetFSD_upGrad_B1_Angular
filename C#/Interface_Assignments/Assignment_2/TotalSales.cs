using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
   class TotalSales : Sales,YearlySales
    {
        public override int MonthlySales()
        {
            return DailySales() * 30;
        }
        public int YearlySales()
        {
            return MonthlySales() * 12;
        }

    }
}
