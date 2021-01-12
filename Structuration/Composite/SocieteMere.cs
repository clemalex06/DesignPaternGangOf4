using System;
using System.Collections.Generic;
namespace Composite
{
    public class SocieteMere:Societe
    {

        public IList<Societe> filiales = new List<Societe>();

        public override bool AjouteFiliale(Societe filiale)
        {
            filiales.Add(filiale);
            return true;
        }

        public override double CalculeCoutEntretien()
        {
            double count = 0;
            foreach (var p in filiales)
                count += p.CalculeCoutEntretien();
            return count + nbrVehicules * countUnitVehicule;
        }
    }
}
