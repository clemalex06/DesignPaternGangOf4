using System;
namespace TemplateMethod
{
    public abstract class Price
    {
        protected double PriceWithoutTax;
        protected double ValueAddedTax;
        protected double PriceWithTax;

        protected abstract void ComputeValueAddedTax();

        public void ComputePriceWithTax()
        {
            ComputeValueAddedTax();
            PriceWithTax = PriceWithoutTax + ValueAddedTax;
        }

        public void SetInitialPrice(double initialPrice)
        {
            PriceWithoutTax = initialPrice;
        }

        public void Display()
        {
            Console.WriteLine("Order");
            Console.WriteLine($"Price Without Tax : {PriceWithoutTax}");
            Console.WriteLine($"Price With Tax : {PriceWithTax}");
        }
    }
}
