using System;
namespace AbstractFactory
{

    /*
     * Abstract Factory's Concept :  
	 * Aims to create objects grouped into families without 
	 * having to know the concrete classes intended for the creation of these objects.
     */
    public class AbstractFactoryMain
    {
        public static int numberOfCars = 3;
        public static int numberOfMotos = 2;

        public static void Main()
        {
            VehicleFactory factory;
            Car[] cars = new Car[numberOfCars];
            Moto[] scooters = new Moto[numberOfMotos];

            Console.WriteLine("Do you want to use Electric (1) " +
                "or Gasoline vehicles (2) Vehicles?");
            string choix = Console.ReadLine();

            if (choix == "1")
            {
                factory = new ElectricVehicleFactory();
            }
            else
            {
                factory = new GasolineVehicleFactory();
            }

            for (int i=0; i < numberOfCars; i++)
            {
                cars[i] = factory.CreateCar("CarModel" + i, "Green", 6 + i, 3.2);
            }

            for (int i = 0; i < numberOfMotos; i++)
            {
                scooters[i] = factory.CreateMoto("MotoModel" + i, "Yellow", 2 + i);
            }

            foreach(var car in cars)
            {
                car.DisplayFeatures();
            }

            foreach(var scooter in scooters)
            {
                scooter.DisplayFeatures();
            }
        }
    }
}
