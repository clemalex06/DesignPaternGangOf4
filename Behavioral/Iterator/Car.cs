using System;
namespace Iterator
{
    public class Car : Element
    {
        public Car(string description) : base(description)
        {
        }

        public void Display()
        {
            Console.WriteLine($"Car 's Description : {Description}");
        }
    }
}
