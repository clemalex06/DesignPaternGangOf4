﻿using System;
namespace AbstractFactory
{
    public class AutomobileElectrique: Automobile
    {
        public AutomobileElectrique(string modele, string couleur, int puissance, double espace)
            :base(modele, couleur, puissance, espace)
        {
        }

        public override void afficheCaracteristique()
        {
            Console.WriteLine($"Automobile electrique de modele : {modele}, " +
                $"de couleur {couleur}, de puissance {puissance}, d'espace {espace}");
        }
    }
}
