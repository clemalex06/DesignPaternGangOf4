using System;
namespace FlighWeight
{
    public class OptionVehicule
    {
        protected string nom;
        protected string description;
        protected int prixStandard;

        public OptionVehicule(string nom)
        {
            this.nom = nom;
            this.description = $"description de {this.nom}";
            this.prixStandard = 100;
        }

        public void affiche( int prixDeVente)
        {
            Console.WriteLine("Option");
            Console.WriteLine($"Nom : {this.nom}");
            Console.WriteLine("description");
            Console.WriteLine($"Prix Standard : {this.prixStandard}");
            Console.WriteLine($"Prix de Vente : {prixDeVente}");
        }
    }
}
