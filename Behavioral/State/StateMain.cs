using System;
namespace State
{
    /*
     * ### State's Concept :
     * Lets an object alter its behavior when its internal state changes.
     * It appears as if the object changed its class.
     */
    public static class StateMain
    {
        public static void Main()
        {
            var order = new Order("Order 1");
            order.Add(new Product("Object 1"));
            order.Add(new Product("Object 2"));
            order.Display();
            order.NextState();
            order.Add(new Product("Object 3"));
            order.Clear();
            order.Display();

            var order2 = new Order("Order 2");
            order2.Add(new Product("Object 11"));
            order2.Add(new Product("Object 21"));
            order2.Display();
            order2.NextState();
            order2.Display();
            order2.NextState();
            order2.Clear();
            order2.Display();



        }
    }
}
