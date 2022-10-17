using System;
namespace AbstractFactory
{
    public class GasolineVehicleFactory : VehicleFactory
    {
        public Car CreateCar(string model, string color, int power, double space)
        {
            return new GasolineCar(model, color, power, space);
        }

        public Moto CreateMoto(string modele, string couleur, int puissance)
        {
            return new GasolineMoto(modele, couleur, puissance);
        }
    }
}
