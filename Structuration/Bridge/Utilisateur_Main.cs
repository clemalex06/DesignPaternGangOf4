using System;

namespace Bridge
{
    /*
     * Concept du Bridge :
     * a pour but de séparer les aspects conceptuels d'une hiérachie
     * de classes de leur implantation
     */
    public class Utilisateur
    {
        public static void Main(string[] args)
        {
            FormulaireImmatriculationLuxembourg formulaire1 =
                new FormulaireImmatriculationLuxembourg(
                    new FormulaireHtmlImpl());
            formulaire1.affiche();
            if (formulaire1.gereSaisie())
                formulaire1.genereDocument();
            Console.WriteLine();

            FormulaireImmatriculationFrance formulaire2 =
                new FormulaireImmatriculationFrance(
                    new FormulaireAppletImpl());
            formulaire2.affiche();
            if (formulaire2.gereSaisie())
                formulaire2.genereDocument();
        }
    }
}
