using System;
namespace Strategy
{
    public class VueVehicule
    {
        protected string description;

        public VueVehicule(string description)
        {
            this.description = description;
        }

        public void dessine()
        {
            Console.Write(description);
        }
    }
}
