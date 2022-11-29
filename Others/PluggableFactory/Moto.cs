using System;
namespace PluggableFactory
{
    public abstract class Moto
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Power { get; set; }

        public abstract void DisplayFeatures();

        public Moto Duplicate()
        {
            Moto result;
            result = (Moto)MemberwiseClone();
            return result;
        }
    }
}
