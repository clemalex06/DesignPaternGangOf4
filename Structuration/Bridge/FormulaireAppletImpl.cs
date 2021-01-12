using System;
namespace Bridge
{
    public class FormulaireAppletImpl:FormulaireImpl
    {
        public void dessineTexte(string texte)
        {
            Console.WriteLine($"Applet : {texte}");
        }

        public string gereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }
}
