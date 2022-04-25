using System;
namespace AbstractFactory
{
    public class ElectricVehicleFactory : VehicleFactory
    {
        public Car CreateCar(string model, string color, int power, double space)
        {
            return new ElectricCar(model, color, power, space);
        }

        public Moto CreateMoto(string modele, string couleur, int puissance)
        {
            return new ElectricMoto(modele, couleur, puissance);
        }
    }
}
