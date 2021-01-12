using System;
namespace Singleton
{
    public class Vendeur
    {
        public string nom { get; set; }
        public string addresse { get; set; }
        public string email { get; set; }

        private static Vendeur _instance = null;

        private Vendeur()
        {
        }

        public static Vendeur Instance()
        {
            if (_instance == null)
                _instance = new Vendeur();
            return _instance;
        }

        public void affiche()
        {
            Console.WriteLine($" Nom : {nom}");
            Console.WriteLine($"Adresse : {addresse}");
            Console.WriteLine($"Email : {email}");
        }
    }
}
