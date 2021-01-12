using System;
using System.Collections.Generic;
namespace Command
{
    public class CommandSolder
    {
        protected IList<Vehicule> vehiculesSolde =
            new List<Vehicule>();

        protected long aujourdhui;
        protected long dureeStock;
        protected double tauxRemise;

        public CommandSolder(long aujourdhui,
            long dureeStock,double tauxRemise)
        {
            this.aujourdhui = aujourdhui;
            this.dureeStock = dureeStock;
            this.tauxRemise = tauxRemise;
        }

        public void Solde(IList<Vehicule> vehicules)
        {
            vehiculesSolde.Clear();
            foreach(var vehicule in vehicules)
            {
                if (vehicule.getDureeStockage(aujourdhui)>=
                    dureeStock)
                {
                    vehiculesSolde.Add(vehicule);
                }
            }

            foreach(var vehicule in vehiculesSolde)
            {
                vehicule.modifiePrix(1 - tauxRemise);
            }
        }

        public  void annule()
        {
            foreach (var vehicule in vehiculesSolde)
                vehicule.modifiePrix(1 / (1 - tauxRemise));
        }

        public void retablit()
        {
            foreach (var vehicule in vehiculesSolde)
                vehicule.modifiePrix(1 - tauxRemise);
        }
    }
}
