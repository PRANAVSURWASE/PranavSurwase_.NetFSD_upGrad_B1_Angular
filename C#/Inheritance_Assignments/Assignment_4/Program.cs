namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricCar ec = new ElectricCar();
            ec.VehicleNumber = "MH12ds3491";
            ec.Brand = "Tesla";
            ec.BatteryCapacity = 50;

            ec.StartVehicle();
            ec.ChargeBattery();
        }
    }
}
