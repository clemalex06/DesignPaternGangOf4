using System;

namespace ChainOfResponsability
{
    /*
     *
     * Concept de la ChainOfResponsability
     *  crée une chaine d'objet telle que si un objet de la chaine
     *  ne peut pas répondre à une requête, il puisse la transmettre à ses
     *  successeurs jusqu'à ce que l'un d'entre eux y réponde
     * 
     */
    public static class ChainOfResponsability
    {
        public static void Main()
        {
            ObjetBase vehicule1 = new Vehicule("Auto++ KT500 Véhicule en bon" +
                "etat");

            Console.WriteLine(vehicule1.donneDescription());

            var model1 = new Modele("KT400", "Vehicule Spacieux et Confortable");

            var vehicule2 = new Vehicule(null);
            vehicule2.suivant = model1;

            Console.WriteLine(vehicule2.donneDescription());

            var marque1 = new Marque("Auto++", "La marque des autos",
                "de gande qualite");

            var modele2 = new Modele("KT700", null);
            modele2.suivant = marque1;

            var vehicule3 = new Vehicule(null);
            vehicule3.suivant = modele2;

            Console.WriteLine(vehicule3.donneDescription());

            var vehicule4 = new Vehicule(null);
            Console.WriteLine(vehicule4.donneDescription());
        }
    }
}
