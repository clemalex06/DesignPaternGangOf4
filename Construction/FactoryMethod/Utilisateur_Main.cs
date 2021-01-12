using System;

namespace FactoryMethod
{
    /*
     *Concept de la Factory Method
     *a pour but d'introduire une méthode abstraite de création d'un objet en reportant aux sous classes concrêtes
     *la création effective
     * 
     */
    public class Utilisateur
    {
        public static void Main(string[] args)
        {
            Client client;
            client = new ClientComptant();
            client.nouvelleCommande(2000);
            client.nouvelleCommande(10000);

            client = new ClientCredit();
            client.nouvelleCommande(2000);
            client.nouvelleCommande(10000);
        }
    }
}
