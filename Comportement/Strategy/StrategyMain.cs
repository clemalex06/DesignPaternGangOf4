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
    public static class StrategyMain
    {
        public static void Main()
        {
            var vueCatalogue1 = new VueCatalogue(new DessinTroisVehiculeLigne());
            vueCatalogue1.dessine();
            var vueCatalogue2 = new VueCatalogue(new DessinUnVehiculeLigne());
            vueCatalogue2.dessine();
        }
    }
}
