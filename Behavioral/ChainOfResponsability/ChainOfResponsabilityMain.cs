using System;

namespace ChainOfResponsability
{
    /*
     * Chain of Responsibility's Concept :
     * lets you pass requests along a chain of handlers. 
     * Upon receiving a request, each handler decides 
     * either to process the request or to pass it to the next handler in the chain.
     */
    public static class ChainOfResponsabilityMain
    {
        public static void Main()
        {
            BaseObject car1 = new Car("Car++ KT500, car in good condition");

            Console.WriteLine(car1.Describe());

            var model1 = new CarModel("KT400", "a spacious and comfortable model");

            var car2 = new Car(null);
            car2.Next = model1;

            Console.WriteLine(car2.Describe());

            var brand1 = new CarBrand("Auto++", "The best car brand", "high quality");

            var model2 = new CarModel("KT700", null);
            model2.Next = brand1;

            var car3 = new Car(null);
            car3.Next = model2;

            Console.WriteLine(car3.Describe());

            var vehicule4 = new Car(null);
            Console.WriteLine(vehicule4.Describe());
        }
    }
}
