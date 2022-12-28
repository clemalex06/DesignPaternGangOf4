namespace FactoryMethod
{
    public abstract class Order
    {
        protected double Amount;

        public Order(double amount)
        {
            Amount = amount;
        }

        public abstract bool IsValid();
        public abstract void Pay();
        public abstract void Reject();
    }
}
