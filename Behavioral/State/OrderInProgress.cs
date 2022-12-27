using System;
namespace State
{
    public class OrderInProgress : OrderState
    {
        public OrderInProgress(Order order):base (order)
        {
        }

        public override void Add(Product product)
        {
            Order.Products.Add(product);
        }

        public override void Clear()
        {
            Order.Products.Clear();
        }

        public override void Display()
        {
            Console.WriteLine("Order State : In Progress");
        }

        public override OrderState NextState()
        {
            return new OrderValidated(Order);
        }

        public override void Remove(Product product)
        {
            Order.Products.Remove(product);
        }
    }
}
