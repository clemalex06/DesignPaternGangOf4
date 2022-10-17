using System;
namespace AbstractFactory
{
    public class GasolineMoto : Moto
    {
        public GasolineMoto(string model, string color, int power)
            : base(model, color, power)
        {
        }

        public override void DisplayFeatures()
        {
            Console.WriteLine($"Gasoline Moto => Model : {model}, " +
                $"Color : {color}, Power : {power}");
        }
    }
}
