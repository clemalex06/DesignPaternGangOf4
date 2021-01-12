using System;
namespace AbstractFactory
{
    public class ScooterEssence:Scooter
    {
        public ScooterEssence(string modele, string couleur, int puissance)
            : base(modele, couleur, puissance)
        {
        }

        public override void afficheCaracteristique()
        {
            Console.WriteLine($"Scooter essence de modele : {modele}, " +
                $"de couleur {couleur}, de puissance {puissance}");
        }
    }
}
