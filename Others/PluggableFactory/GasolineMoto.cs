using System;
namespace PluggableFactory
{
    public class GasolineMoto : Moto
    {
        public override void DisplayFeatures()
        {
            Console.WriteLine($"Gasoline Moto => Model : {Model}, " +
                $"Color : {Color}, Power : {Power}");
        }
    }
}
