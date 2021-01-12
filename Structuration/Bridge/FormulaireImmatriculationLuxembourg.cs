using System;
namespace Bridge
{
    public class FormulaireImmatriculationLuxembourg:FormulaireImmatriculation
    {
        public FormulaireImmatriculationLuxembourg(FormulaireImpl implantation)
            :base(implantation)
        {
        }

        protected override bool controleSaisie(string plaque)
        {
            return plaque.Length == 5;
        }
    }
}
