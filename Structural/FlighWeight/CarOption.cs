using System;
namespace FlighWeight
{
    public class CarOption
    {
        protected string Name;
        protected string Description;
        protected int RegularPrice;

        public CarOption(string name)
        {
            Name = name;
            Description = $"Description of {Name}";
            RegularPrice = 100;
        }

        public void Display(int sellingPrice)
        {
            Console.WriteLine("Option");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine("Description");
            Console.WriteLine($"Regular Price : {RegularPrice}");
            Console.WriteLine($"Selling Price : {sellingPrice}");
        }
    }
}
