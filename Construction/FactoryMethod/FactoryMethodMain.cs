using System;

namespace FactoryMethod
{
    /*
     *Concept de la Factory Method
     *a pour but d'introduire une méthode abstraite de création d'un objet en reportant aux sous classes concrêtes
     *la création effective
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
