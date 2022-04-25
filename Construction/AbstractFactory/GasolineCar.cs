using System;
namespace AbstractFactory
{
    public class GasolineCar : Car
    {
        public GasolineCar(string model, string color, int power, double space)
            : base(model, color, power, space)
        {
        }

        public override void DisplayFeatures()
        {
            Console.WriteLine($"Gasoline Car => Model : {Model}, " +
                $"Color : {Color}, Power : {Power}, Space : {Space}");
        }
    }
}
