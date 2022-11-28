using System;
namespace State
{
    public class Product
    {
        protected string Name;

        public Product(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Product : {Name}");
        }
    }
}
