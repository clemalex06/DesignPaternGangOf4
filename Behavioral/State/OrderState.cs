using System;
namespace State
{
    public abstract class OrderState
    {
        protected Order Order;
        public OrderState(Order order)
        {
            this.Order = order;
        }

        public abstract void Add(Product product);
        public abstract void Clear();
        public abstract void Remove(Product product);
        public abstract void Display();
        public abstract OrderState NextState();
    }
}
