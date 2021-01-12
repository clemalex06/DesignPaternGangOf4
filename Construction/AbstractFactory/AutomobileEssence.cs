using System;
namespace AbstractFactory
{
    public class AutomobileEssence:Automobile
    {
        public AutomobileEssence(string modele, string couleur, int puissance, double espace)
            : base(modele, couleur, puissance, espace)
        {
        }

        public override void afficheCaracteristique()
        {
            Console.WriteLine($"Automobile essence de modele : {modele}, " +
    $"de couleur {couleur}, de puissance {puissance}, d'espace {espace}");
        }
    }
}
