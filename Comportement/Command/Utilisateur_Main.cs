using System;

namespace Command
{
    public class Utilisateur
    {

        /*
         *
         *Concept du Command
         * a pour objectif de transformer une requête en un objet
         * facilitant des opérattions comme l'annulation, la mise en file des
         * requêtes et leur suivi
         * 
         */
        public static void Main(string[] args)
        {
            var vehicule1 = new Vehicule("A01", 1, 1000);
            var vehicule2 = new Vehicule("A02", 6, 2000);
            var vehicule3 = new Vehicule("A03", 2, 3000);

            var catalogue = new Catalogue();
            catalogue.ajoute(vehicule1);
            catalogue.ajoute(vehicule2);
            catalogue.ajoute(vehicule3);

            Console.WriteLine("Affichage du catalogue initial");
            catalogue.affiche();
            Console.WriteLine();

            var commandeSolder = new CommandSolder(10, 5, 0.1);
            catalogue.lanceCommandeSolder(commandeSolder);
            Console.WriteLine("Affichage du catalogue apres execution de la " +
                "premiere commande");
            catalogue.affiche();
            Console.WriteLine();
            var commandeSoler2 = new CommandSolder(10, 5, 0.5);
            catalogue.lanceCommandeSolder(commandeSoler2);

            Console.WriteLine("Affichage du catalogue apres execution de la " +
            "seconde commande");
            catalogue.affiche();
            Console.WriteLine();
            catalogue.annuleCommandeSolder(1);
            Console.WriteLine("Affichage du catalogue apres annulation de la " +
                "premiere commande");
            catalogue.affiche();
            Console.WriteLine();
            catalogue.retablitCommandeSolder(1);
            Console.WriteLine("Affichage du catalogue apres execution de la " +
                "premiere commande");
            catalogue.affiche();
            Console.WriteLine();



        }
    }
}
