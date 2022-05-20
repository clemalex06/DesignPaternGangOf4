using System;

namespace FactoryMethod
{
    /*
     * Factory Method's Concept :
     * Defines an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
     * 
     */
    public static class FactoryMethodMain
    {
        public static void Main()
        {
            Customer client;
            client = new CustomerOnCash();
            client.NewOrder(2000);
            client.NewOrder(10000);

            client = new CustomerOnCredit();
            client.NewOrder(2000);
            client.NewOrder(10000);
        }
    }
}
