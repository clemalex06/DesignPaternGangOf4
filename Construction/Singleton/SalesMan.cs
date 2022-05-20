using System;
namespace Singleton
{
    public class SalesMan
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }

        private static SalesMan _instance = null;

        private SalesMan()
        {
        }

        public static SalesMan Instance()
        {
            if (_instance == null)
                _instance = new SalesMan();
            return _instance;
        }

        public void Display()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Adress : {Adress}");
            Console.WriteLine($"Email : {Email}");
        }
    }
}
