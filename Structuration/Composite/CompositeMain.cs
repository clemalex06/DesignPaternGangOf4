using System;

namespace Composite
{
    /*
     *
     * Concept du composite
     * offre un cadre de onception d'une composition
     * dont la profondeur de composition est variable, la conception etant
     * basée sur un arbre
     * 
     */
    public static class CompositeMain
    {
        public static void Main()
        {
            var societe1 = new SocieteSansFilliale();
            societe1.ajouteVehicule();
            var societe2 = new SocieteSansFilliale();
            societe2.ajouteVehicule();
            societe2.ajouteVehicule();

            var groupe = new SocieteMere();
            groupe.ajouteVehicule();
            groupe.AjouteFiliale(societe1);
            groupe.AjouteFiliale(societe2);
            Console.WriteLine($"Cout d'entretien total" +
                $" du groupe : " +
                $"{groupe.CalculeCoutEntretien()}");

        }
    }
}
