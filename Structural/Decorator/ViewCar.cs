using System;
namespace Decorator
{
    public class ViewCar: ICarDisplayComponent
    {
        public void Display()
        {
            Console.WriteLine("Display Car");
        }
    }
}
