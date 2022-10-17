using System;
namespace Decorator
{
    public class DecoratorForModel : Decorator
    {
        public DecoratorForModel(ICarDisplayComponent composant) :
            base(composant)
        {
        }

        protected void DisplayTechnicalInfos()
        {
            Console.WriteLine("Technical Informations for Car model");
        }

        public override void Display()
        {
            base.Display();
            DisplayTechnicalInfos();
        }
    }
}
