using System;
namespace Observer
{
    /*
     * ### Observer's Concept :
     * Lets you define a subscription mechanism to notify multiple objects about any events 
     * that happen to the object they’re observing.
     */
    public class ObserverMain
    {
        public static void Main()
        {
            var car = new Car();
            car.Description = "Cheap Car";
            car.Price = 5000;
            var carObserver = new CarObserver(car);
            carObserver.ReWrite();
            car.Price = 4500;
            carObserver = new CarObserver(car);
            car.Price = 5500;
        }
    }
}
