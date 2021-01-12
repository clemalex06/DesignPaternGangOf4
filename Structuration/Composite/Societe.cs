using System;
namespace Composite
{
    public abstract class Societe
    {
        protected static double countUnitVehicule = 5;
        protected int nbrVehicules;

        public void ajouteVehicule()
        {
            nbrVehicules += 1;
        }

        public abstract double CalculeCoutEntretien();

        public abstract bool AjouteFiliale(Societe filiale);
    }
}
