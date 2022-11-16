using System;
namespace Strategy
{
    public class CarView
    {
        protected string Description;

        public CarView(string description)
        {
            this.Description = description;
        }

        public void Draw()
        {
            Console.Write(Description);
        }
    }
}
