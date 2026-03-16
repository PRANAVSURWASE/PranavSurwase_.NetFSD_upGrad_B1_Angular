using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    internal class Vehicle
    {
        public string VehicleNumber { get; set; }
        public string Brand { get; set; }

        public void StartVehicle()
        {
            Console.WriteLine("Vehicle Started.....");
        }
    }
}
