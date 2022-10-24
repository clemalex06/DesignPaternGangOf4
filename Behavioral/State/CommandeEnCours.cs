using System;
namespace State
{
    public class CommandeEnCours : EtatCommande
    {
        public CommandeEnCours(Commande commande):base (commande)
        {
        }

        public override void ajouteProduit(Produit produit)
        {
            commande.Produits.Add(produit);
        }

        public override void efface()
        {
            commande.Produits.Clear();
        }

        public override EtatCommande etatSuivant()
        {
            return new CommandeValidee(commande);
        }

        public override void retireProduit(Produit produit)
        {
            commande.Produits.Remove(produit);
        }
    }
}
