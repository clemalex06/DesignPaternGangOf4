using System;
namespace Bridge
{
    public class FormulaireHtmlImpl : FormulaireImpl
    {
        public void dessineTexte(string texte)
        {
            Console.WriteLine($"HTML : {texte}");
        }

        public string gereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }
}
