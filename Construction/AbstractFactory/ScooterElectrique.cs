using System;
namespace AbstractFactory
{
    public class ScooterElectrique: Scooter
    {
        public ScooterElectrique(string modele, string couleur, int puissance)
            :base( modele,  couleur,  puissance)
        {
        }

        public override void afficheCaracteristique()
        {
            Console.WriteLine($"Scooter electrique de modele : {modele}, " +
                $"de couleur {couleur}, de puissance {puissance}");
        }
    }
}
