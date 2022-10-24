using System;
namespace FactoryMethod
{
    public abstract class Order
    {
        protected double Amount;

        public Order(double montant)
        {
            Amount = montant;
        }

        public abstract bool IsValid();
        public abstract void Pay();
        public abstract void Reject();
    }
}
