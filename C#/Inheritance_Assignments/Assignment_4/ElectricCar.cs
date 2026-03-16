using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    internal class ElectricCar:Car
    {
         public int BatteryCapacity { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Battery Charging.......");
        }
    }
}
