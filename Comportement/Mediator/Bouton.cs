using System;
namespace Mediator
{
    public class Bouton : Controle
    {
        public Bouton(string nom):base(nom)
        {
        }

        public override void saisie()
        {
            Console.WriteLine($"Desirez-vous activer le bouton " +
                $"{nom} ??");
            string reponse = Console.ReadLine();
            if (reponse == "oui")
                this.modifie();
        }
    }
}
