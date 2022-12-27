using System;
namespace FactoryMethod
{
    public class CashOrder : Order
    {
        public CashOrder(double montant) : base(montant)
        {
        }

        public override void Pay()
        {
            Console.WriteLine($"the payment for the Cash Order of {Amount} euros was successful");
        }

        public override bool IsValid()
        {
            return true;
        }

        public override void Reject()
        {
            Console.WriteLine($"the payment for the Cash Order of {Amount} euros was rejected");
        }
    }
}
