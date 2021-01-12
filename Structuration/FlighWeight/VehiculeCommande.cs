using System;
using System.Collections.Generic;

namespace FlighWeight
{
    public class VehiculeCommande
    {
        public IList<OptionVehicule> options = new
            List<OptionVehicule>();
        protected IList<int> prixDeVenteOptions =
            new List<int>();

        public void ajouteOptions(string nom, int prixDeVente,
            FabriqueOption fabrique)
        {
            options.Add(fabrique.getOption(nom));
            prixDeVenteOptions.Add(prixDeVente);
        }

        public void afficheOptions()
        {
            int index, taille;

            taille = options.Count;

            for (index = 0; index < taille; index++)
            {
                options[index].affiche(prixDeVenteOptions[index]);
                Console.WriteLine();
            }
        }
    }
}
