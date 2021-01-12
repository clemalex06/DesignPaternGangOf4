using System;
namespace Builder
{
    public class Vendeur
    {
        protected ConstructeurLiasseVehicule constructeur;
        public Vendeur(ConstructeurLiasseVehicule constructeur)
        {
            this.constructeur = constructeur;
        }

        public Liasse construit(string nomclient)
        {
            constructeur.construitBondeCommande(nomclient);
            constructeur.construitDemandeImmatriculation(nomclient);
            return constructeur.resultat();
        }
    }
}
