namespace Decorator
{
    /*
     * Decorator's Concept :
     * Lets you attach new behaviors to objects by 
     * placing these objects inside special wrapper objects that contain the behaviors.
     */
    public static class DecoratorMain
    {
        public static void Main()
        {
            var viewCar = new ViewCar();
            var decoratorForModel = new DecoratorForModel(viewCar);
            var decoratorForBrand = new DecoratorForBrand(decoratorForModel);
            decoratorForBrand.Display();
        }
    }
}
