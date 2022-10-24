using System;
namespace AbstractFactory
{
    public class ElectricMoto : Moto
    {
        public ElectricMoto(string model, string color, int power)
            : base(model, color, power)
        {
        }

        public override void DisplayFeatures()
        {
            Console.WriteLine($"Electric Moto => Model : {model}, " +
                $"Color : {color}, Power : {power}");
        }
    }
}
