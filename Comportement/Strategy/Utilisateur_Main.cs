using System;

namespace Strategy
{
    /*
     *
     * Concept du Strategy
     * adatpte le comportement et les algorithmes d'un objet en fonction
     * d'un besoin sans changer les interactions avec le client de cet objet
     * 
     */
    public class Utilisateur
    {
        public static void Main(string[] args)
        {
            var vueCatalogue1 = new VueCatalogue(new DessinTroisVehiculeLigne());
            vueCatalogue1.dessine();
            var vueCatalogue2 = new VueCatalogue(new DessinUnVehiculeLigne());
            vueCatalogue2.dessine();
        }
    }
}
