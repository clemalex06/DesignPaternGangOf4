using System;
namespace PluggableFactory
{
    public class ScooterEssence : Scooter
    {
        public override void afficheCaracteristiques()
        {
            Console.WriteLine($"Scooter essence de modele : " +
                $"{modele}, de couleur : {couleur}, " +
                $"de puissance : {puissance}, ");
        }
    }
}
