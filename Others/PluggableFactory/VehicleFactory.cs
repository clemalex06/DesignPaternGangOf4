using System;
namespace PluggableFactory
{
    public class VehicleFactory
    {
        public Car CarPrototype { get; set; }
        public Moto MotoPrototype { get; set; }

        public VehicleFactory()
        {
            CarPrototype = null;
            MotoPrototype = null;
        }

        public VehicleFactory (Car automobile,Moto scooter)
        {
            CarPrototype = automobile;
            MotoPrototype = scooter;
        }

        public Car CreateCar()
        {
            if (CarPrototype == null)
                return null;
            return CarPrototype.Duplicate();
        }

        public Moto CreateMoto()
        {
            if (MotoPrototype == null)
                return null;
            return MotoPrototype.Duplicate();
        }
    }
}
