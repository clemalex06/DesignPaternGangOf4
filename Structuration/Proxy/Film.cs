using System;
namespace Proxy
{
    public class Film : Animation
    {

        public void clic()
        {
        }

        public void dessine()
        {
            Console.WriteLine("Affichage du film");
        }

        public void charge()
        {
            Console.WriteLine("Chargement du film");
        }

        public void joue()
        {
            Console.WriteLine("Lecture du film");
        }
    }
}
