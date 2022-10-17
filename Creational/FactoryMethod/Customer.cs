using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class Customer
    {
        protected IList<Order> orders = new List<Order>();

        protected abstract Order CreateOrder(double amount);

        public void NewOrder(double amount)
        {
            var order = CreateOrder(amount);
            if (order.IsValid())
            {
                order.Pay();
                orders.Add(order);
            }
            else
            {
                order.Reject();
            }
        }
    }
}
