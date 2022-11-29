using System;
namespace PluggableFactory
{

    public class ElectricCar : Car
    {
        public override void DisplayFeatures()
        {
            Console.WriteLine($"Electric Car => Model : {Model}, " +
                $"Color : {Color}, Power : {Power}, Space : {Space}");
        }
    }
}
