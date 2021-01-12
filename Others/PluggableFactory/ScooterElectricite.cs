using System;
namespace PluggableFactory
{
    public class ScooterElectricite : Scooter
    {
        public override void afficheCaracteristiques()
        {
            Console.WriteLine($"Scooter electrique de modele : " +
                $"{modele}, de couleur : {couleur}, " +
                $"de puissance : {puissance}, ");
        }
    }
}
