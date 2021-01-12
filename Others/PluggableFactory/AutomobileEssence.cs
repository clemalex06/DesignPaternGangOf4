using System;
namespace PluggableFactory
{
    public class AutomobileEssence : Automobile
    {
        public override void afficheCaracteristiques()
        {
            Console.WriteLine($"Automobile essence de modele : " +
                $"{modele}, de couleur : {couleur}, " +
                $"de puissance : {puissance}, " +
                $"d'espace : {espace}");
        }
    }
}
