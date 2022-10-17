using System;
namespace AbstractFactory
{
    public interface VehicleFactory
    {
        Car CreateCar(string model, string color, int power, double space);
        Moto CreateMoto(string model, string color, int power);
    }
}
