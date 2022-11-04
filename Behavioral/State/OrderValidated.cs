using System;
namespace State
{
    public class OrderValidated : OrderState
    {
        public OrderValidated(Order order):base(order)
        {
        }

        public override void Add(Product product)
        {
        }

        public override void Clear()
        {
            Order.Products.Clear();
        }

        public override void Display()
        {
            Console.WriteLine("Order State : Validated");
        }

        public override OrderState NextState()
        {
            return new OrderDelivered(Order);
        }

        public override void Remove(Product product)
        {
        }
    }
}
