using System;

namespace Builder
{
    /*
     *
     * Concept du Builder
     * permet de séparer la construction d'objets complexes de leur implantation
     * de sorte qu'un client puisse créer ces objets complexes avec des implantations différentes 
     * 
     */

    public static class BuilderMain
    {
        public static void Main()
        {
            ConstructeurLiasseVehicule constructeur;
            Console.WriteLine(" voulez construire des liasses html (1) ou des liasses pdf (2) :");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else
            {
                constructeur = new ConstructeurLiasseVehiculePdf();
            }

            var vendeur = new Vendeur(constructeur);
            Liasse liasse = vendeur.construit("Martin");
            liasse.imprime();
        }
    }
}
