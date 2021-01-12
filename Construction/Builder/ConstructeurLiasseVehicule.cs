using System;
namespace Builder
{
    public abstract class ConstructeurLiasseVehicule
    {
        protected Liasse liasse;

        public abstract void construitBondeCommande(string nomlient);

        public abstract void construitDemandeImmatriculation(string nomDemandeur);

        public Liasse resultat()
        {
            return liasse;
        }
    }
}
