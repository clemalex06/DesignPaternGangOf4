using System;
namespace Decorator
{
    public class VueVehicule: ComposantGraphiqueVehicule
    {
        public void affiche()
        {
            Console.WriteLine("Affichage du vehicule");
        }
    }
}
