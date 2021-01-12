using System;
namespace State
{
    public class Produit
    {
        protected string nom;

        public Produit(string nom)
        {
            this.nom = nom;
        }

        public void affiche()
        {
            Console.WriteLine($"Produit : {nom}");
        }
    }
}
