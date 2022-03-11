﻿using System;
namespace FactoryMethod
{
    public class CommandeComptant:Commande
    {
        public CommandeComptant(double montant):base(montant)
        {
        }

        public override void paye()
        {
            Console.WriteLine($"Le paiement de la commande au comptant de " +
                $"{montant} est effectue");
        }

        public override bool valide()
        {
            return true;
        }
    }
}