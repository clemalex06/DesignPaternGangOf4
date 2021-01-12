using System.Collections.Generic;
namespace Command
{
    public class Catalogue
    {
        protected IList<Vehicule> VehiculesStock =
            new List<Vehicule>();
        protected IList<CommandSolder> commandes =
            new List<CommandSolder>();

        public void lanceCommandeSolder(CommandSolder commande)
        {
            commandes.Insert(0, commande);
            commande.Solde(VehiculesStock);
        }

        public void annuleCommandeSolder( int ordre)
        {
            commandes[ordre].annule();
        }

        public void retablitCommandeSolder(int ordre)
        {
            commandes[ordre].retablit();
        }

        public void ajoute(Vehicule vehicule)
        {
            VehiculesStock.Add(vehicule);
        }

        public void affiche()
        {
            foreach (var vehicule in VehiculesStock)
                vehicule.affiche();
        }
    }
}
