using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    internal class Cot:Furniture
    {
        public string CotType;
        public string MaterialType;
        public string Capacity;
        public double Rate;

        public override void getData()
        {
            base.getData();

            Console.WriteLine("Enter Cot Type (Wood/Steel):");
            CotType = Console.ReadLine();

            Console.WriteLine("Enter Material Type:");
            Console.WriteLine("Wood: Teak/Rose");
            Console.WriteLine("Steel: Gray/Green/Brown");
            MaterialType = Console.ReadLine();

            Console.WriteLine("Enter Capacity (Single/Double):");
            Capacity = Console.ReadLine();

            Console.WriteLine("Enter Rate:");
            Rate = Convert.ToDouble(Console.ReadLine());

            TotalAmt = Rate * Qty;
        }
        public override void showData()
        {

            base.showData();
            Console.WriteLine("Cot Type: " + CotType);
            Console.WriteLine("Material Type: " + MaterialType);
            Console.WriteLine("Capacity: " + Capacity);
            Console.WriteLine("Rate: " + Rate);
            Console.WriteLine("Total Amount: " + TotalAmt);

        }
    }
}
