using System;
using System.Collections.Generic;

namespace Strategy
{
    public class DessinUnVehiculeLigne : DessinCatalogue
    {
        public void dessine(IList<VueVehicule> contenu)
        {
            Console.WriteLine("Dessine les vehicules avec un vehicule par ligne");

            foreach(var v in contenu)
            {
                v.dessine();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
