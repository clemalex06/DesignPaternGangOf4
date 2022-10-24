using System;

namespace State
{
    /*
     *
     * Concept du State
     * permet a un objet d'adapter son comportement en fonction de son etat
     * interne
     * 
     */
    public static class StateMain
    {
        public static void Main()
        {
            var commande = new Commande();
            commande.ajouteProduit(new Produit("Vehicule 1"));
            commande.ajouteProduit(new Produit("Accessoire 2"));
            commande.affiche();
            commande.etatSuivant();
            commande.ajouteProduit(new Produit("Accessoire 3"));
            commande.efface();
            commande.affiche();

            var commande2 = new Commande();
            commande2.ajouteProduit(new Produit("Vehicule 11"));
            commande2.ajouteProduit(new Produit("Accessoire 21"));
            commande2.affiche();
            commande2.etatSuivant();
            commande2.affiche();
            commande2.etatSuivant();
            commande2.efface();
            commande2.affiche();



        }
    }
}
