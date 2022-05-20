using System;
namespace FactoryMethod
{
    public class CustomerOnCredit : Customer
    {
        protected override Order CreateOrder(double amount)
        {
            return new CreditOrder(amount);
        }
    }
}
