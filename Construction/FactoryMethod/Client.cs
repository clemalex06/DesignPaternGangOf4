using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class Client
    {
        protected IList<Commande> commandes = new List<Commande>();

        protected abstract Commande creeCommande(double montant);

        public void nouvelleCommande(double montant)
        {
            var commande = this.creeCommande(montant);
            if (commande.valide())
            {
                commande.paye();
                commandes.Add(commande);
            }
        }
    }
}
