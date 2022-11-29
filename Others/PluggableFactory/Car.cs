using System;
namespace PluggableFactory
{
    public abstract class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Power { get; set; }
        public double Space { get; set; }

        public abstract void DisplayFeatures();

        public Car Duplicate()
        {
            Car result;
            result = (Car)MemberwiseClone();
            return result;
        }
    }
}
