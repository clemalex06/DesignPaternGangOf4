using System;
using System.Collections.Generic;

namespace Strategy
{
    public class DessinTroisVehiculeLigne : DessinCatalogue
    {
        public DessinTroisVehiculeLigne()
        {
        }

        public void dessine(IList<VueVehicule> contenu)
        {
            Console.WriteLine("Dessine les vehicules avec trois vehicules par ligne");
            int compteur = 0;

            foreach (var v in contenu)
            {
                v.dessine();
                compteur++;
                if (compteur == 3)
                {
                    Console.WriteLine();
                    compteur = 0;
                }
                else
                    Console.Write(" ");
            }
            if (compteur != 0)
                Console.WriteLine();
            Console.WriteLine();
        }
    }
}
