using System;
namespace State
{
    public class CommandeValidee : EtatCommande
    {
        public CommandeValidee(Commande commande):base(commande)
        {
        }

        public override void ajouteProduit(Produit produit)
        {
        }

        public override void efface()
        {
            commande.Produits.Clear();
        }

        public override EtatCommande etatSuivant()
        {
            return new CommandeLivree(commande);
        }

        public override void retireProduit(Produit produit)
        {
        }
    }
}
