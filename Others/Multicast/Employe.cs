using System;
namespace Multicast
{
    public abstract class Employe: RecepteurGeneral
    {
        protected string nom;

        public Employe(string nom)
        {
            this.nom = nom;
        }

        public void recoit(MessageGeneral message)
        {
            Console.WriteLine("Message general");
            Console.WriteLine($"Nom : {nom}");
            Console.WriteLine("Message : ");
            foreach (var ligne in message.contenu)
                Console.WriteLine(ligne);
        }
    }
}
