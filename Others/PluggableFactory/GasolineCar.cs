using System;
namespace PluggableFactory
{
    public class GasolineCar : Car
    {
        public override void DisplayFeatures()
        {
            Console.WriteLine($"Gasoline Car => Model : {Model}, " +
                $"Color : {Color}, Power : {Power}, Space : {Space}");
        }
    }
}
