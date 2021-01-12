using System;

namespace AbstractFactory
{

    /*
     * Concept de l'abstract Factory
     *a pour objectif la création d'objet regroupés en famille sanse devoir connaître
     * les classes concrêtes destinées à la création de ces objets
     * 
     */
    public class Catalogue
    {
        public static int nbAutos = 3;
        public static int nbScooters = 2;

        public static void Main(string[] args)
        {
            FabriqueVehicule fabrique;
            Automobile[] autos = new Automobile[nbAutos];
            Scooter[] scooters = new Scooter[nbScooters];

            Console.WriteLine("Voulez-vous utiliser des vehicules electriques (1) " +
                "ou essence (2)?");
            string choix = Console.ReadLine();

            if (choix == "1")
            {
                fabrique = new FabriqueVehiculeElectrique();
            }
            else
            {
                fabrique = new FabriqueVehiculeEssence();
            }

            for (int i=0; i < nbAutos; i++)
            {
                autos[i] = fabrique.CreeAutomobile("modele auto " + i, "vert" + i, 6 + i, 3.2);
            }

            for (int i = 0; i < nbScooters; i++)
            {
                scooters[i] = fabrique.CreeScooter("modele sccoter " + i, "jaune", 2 + i);
            }

            foreach(var auto in autos)
            {
                auto.afficheCaracteristique();
            }

            foreach(var scooter in scooters)
            {
                scooter.afficheCaracteristique();
            }
        }
    }
}
