using System;
namespace Decorator
{
    public class DecoratorForBrand : Decorator
    {
        public DecoratorForBrand(ICarDisplayComponent composant) :
            base(composant)
        {
        }

        protected void DisplayLogo()
        {
            Console.WriteLine("Brand Logo");
        }

        public override void Display()
        {
            base.Display();
            DisplayLogo();
        }
    }
}
