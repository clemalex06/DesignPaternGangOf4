using System;
namespace FactoryMethod
{
    public class CommandeCredit:Commande
    {
        public CommandeCredit(double montant):base(montant)
        {
        }

        public override void paye()
        {
            Console.WriteLine($"Le paiement de la commande au credit de " +
                $"{montant} est effectue");
        }

        public override bool valide()
        {
            return (montant >= 1000) && (montant<=5000);
        }
    }
}
