using System;
namespace State
{
    public class OrderDelivered : OrderState
    {
        public OrderDelivered(Order order):base(order)
        {
        }

        public override void Add(Product product)
        {
        }

        public override void Clear()
        {
        }

        public override void Display()
        {
            Console.WriteLine("Order State : Delivered");
        }

        public override OrderState NextState()
        {
            return this;
        }

        public override void Remove(Product product)
        {
        }
    }
}
