using System;
namespace Prototype
{
    public class SessionCertificateDocument : Document
    {
        public override void Display()
        {
            Console.WriteLine($"Display the Session Certificate : {Content}");
        }

        public override void Print()
        {
            Console.WriteLine($"Print the Session Certificate : {Content}");
        }
    }
}
