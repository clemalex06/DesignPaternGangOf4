using System;
namespace PluggableFactory
{
    public class ElectricMoto : Moto
    {
        public override void DisplayFeatures()
        {
            Console.WriteLine($"Electric Moto => Model : {Model}, " +
                $"Color : {Color}, Power : {Power}");
        }
    }
}
