using System;
using System.Collections.Generic;
namespace State
{
    public class Order
    {
        protected IList<Product> products = new List<Product>();

        public IList<Product> Products
        {
            get
            {
                return products;
            }
        }

        protected string Name = string.Empty;

        protected OrderState OrderState;

        public Order(string name)
        {
            OrderState = new OrderInProgress(this);
            Name = name;
        }

        public void Add(Product product)
        {
            OrderState.Add(product);
        }

        public void Remove(Product product)
        {
            OrderState.Remove(product);
        }

        public void Clear()
        {
            OrderState.Clear();
        }

        public void NextState()
        {
            OrderState = OrderState.NextState();
        }

        public void Display()
        {
            Console.WriteLine($"Order Name : '{Name}'");
            OrderState.Display();
            Console.WriteLine("Order Content");
            foreach (var product in Products)
            {
                product.Display();
            }
            Console.WriteLine();
        }
    }
}
