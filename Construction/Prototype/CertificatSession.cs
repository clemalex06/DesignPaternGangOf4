using System;
namespace Prototype
{
    public class CertificatSession:Document
    {
        public override void affiche()
        {
            Console.WriteLine($"Affiche le certificat de session : {contenu}");
        }

        public override void imprime()
        {
            Console.WriteLine($"Imprime le certificat de session : {contenu}");
        }
    }
}
