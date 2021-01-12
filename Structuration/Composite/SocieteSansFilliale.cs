using System;
namespace Composite
{
    public class SocieteSansFilliale : Societe
    {
        public override bool AjouteFiliale(Societe filiale)
        {
            return false;
        }

        public override double CalculeCoutEntretien()
        {
            return nbrVehicules * countUnitVehicule;
        }
    }
}
