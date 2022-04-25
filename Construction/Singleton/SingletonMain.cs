using System;

namespace Singleton
{
    /*
     *
     *Concept du singleton
     * permet de s'assurer qu'une classe ne possède qu'une seule instance
     * et de fournir une méthode unique retournant cette instance
     * 
     */
    public static class SingletonMain
    {
        public static void Main()
        {
            Vendeur levendeur = Vendeur.Instance();
            levendeur.addresse = "1 allée des chaumieres";
            levendeur.nom = "vendeur auto";
            levendeur.email = "email@emao.fr";
            affiche();
        }

        public static void affiche()
        {
            Vendeur levendeur = Vendeur.Instance();
            levendeur.affiche();
        }
    }
}
