using System;
namespace FactoryMethod
{
    public class CreditOrder : Order
    {
        public CreditOrder(double montant) : base(montant)
        {
        }

        public override void Pay()
        {
            Console.WriteLine($"the payment for the Credit Order of {Amount} euros was successful");
        }

        public override bool IsValid()
        {
            return (Amount >= 1000) && (Amount <= 5000);
        }

        public override void Reject()
        {
            Console.WriteLine($"the payment for the Credit Order of {Amount} euros was rejected");
        }
    }
}
