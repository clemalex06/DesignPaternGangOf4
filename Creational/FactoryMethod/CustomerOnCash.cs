namespace FactoryMethod
{
    public class CustomerOnCash : Customer
    {
        protected override Order CreateOrder(double amount)
        {
            return new CashOrder(amount);
        }
    }
}
