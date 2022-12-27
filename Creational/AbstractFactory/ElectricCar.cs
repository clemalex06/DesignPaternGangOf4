using System;
namespace AbstractFactory
{
    public class ElectricCar : Car
    {
        public ElectricCar(string model, string color, int power, double space)
            : base(model, color, power, space)
        {
        }

        public override void DisplayFeatures()
        {
            Console.WriteLine($"Electric Car => Model : {Model}, " +
                $"Color : {Color}, Power : {Power}, Space : {Space}");
        }
    }
}
