using System;
namespace Prototype
{
    public class ApplicationForRegistrationDocument : Document
    {
        public override void Display()
        {
            Console.WriteLine($"Display the Application For Registration : {Content}");
        }

        public override void Print()
        {
            Console.WriteLine($"Print the Application For Registration : {Content}");
        }
    }
}
