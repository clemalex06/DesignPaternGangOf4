namespace PluggableFactory
{
    /*
     * ### Pluggable Factory's Concept :
     * It's a design pattern which implementents  Abstract Factory + Prototype
     */
    public static class PluggableFactoryMain
    {
        public static void Main()
        {
            var blueStandardCar = new ElectricCar();
            blueStandardCar.Model = "Standard";
            blueStandardCar.Color = "Blue";

            var redClassicalMoto = new GasolineMoto();
            redClassicalMoto.Model = "Classical";
            redClassicalMoto.Color = "Red";

            var factory = new VehicleFactory();
            factory.CarPrototype = blueStandardCar;
            factory.MotoPrototype = redClassicalMoto;

            var car = factory.CreateCar();
            car.DisplayFeatures();

            var moto = factory.CreateMoto();
            moto.DisplayFeatures();
        }
    }
}
