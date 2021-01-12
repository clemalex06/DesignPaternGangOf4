using System;
namespace Bridge
{
    public class FormulaireImmatriculationFrance:FormulaireImmatriculation
    {
        public FormulaireImmatriculationFrance(FormulaireImpl implantation)
            : base(implantation)
        {
        }

        protected override bool controleSaisie(string plaque)
        {
            return plaque.Length == 7;
        }
    }
}
