using System;
namespace PluggableFactory
{
    public class AutomobileElectricite : Automobile
    {

        public override void afficheCaracteristiques()
        {
            Console.WriteLine($"Automobile electrique de modele : " +
                $"{modele}, de couleur : {couleur}, " +
                $"de puissance : {puissance}, " +
                $"d'espace : {espace}");
        }
    }
}
