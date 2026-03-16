using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6
{
    internal class Chair:Furniture
    {
        public string ChairType;
        public string Purpose;
        public string MaterialType;
        public double Rate;

        public void getData()
        {
            base.getData();

            Console.WriteLine("Enter Chair Type(Wooden/Steel/Plastic)");
            ChairType = Console.ReadLine();

            Console.WriteLine("Enter Purpose(Home.Office)");
            Purpose = Console.ReadLine();

            Console.WriteLine("Enter Material Type :");
            Console.WriteLine("Wood: Teak/Rose");
            Console.WriteLine("Steel: Gray/Green/Brown");
            Console.WriteLine("Plastic: Green/Red/Blue/White");
            MaterialType = Console.ReadLine();

            Console.WriteLine("Enter Rate ");
            Rate = Convert.ToDouble(Console.ReadLine());


            TotalAmt = Rate * Qty;



        }

        public override void showData()
        {
            base.showData();
            Console.WriteLine("Chair Type: " + ChairType);
            Console.WriteLine("Purpose: " + Purpose);
            Console.WriteLine("Material Type: " + MaterialType);
            Console.WriteLine("Rate: " + Rate);
            Console.WriteLine("Total Amount: " + TotalAmt);

        }

    }
}
