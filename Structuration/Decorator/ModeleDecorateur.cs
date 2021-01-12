using System;
namespace Decorator
{
    public class ModeleDecorateur: Decorateur
    {
        public ModeleDecorateur(ComposantGraphiqueVehicule composant) :
            base(composant)
        {
        }

        protected void afficheInfosTechniques()
        {
            Console.WriteLine("Informations techniques du Modele");
        }

        public override void affiche()
        {
            base.affiche();
            this.afficheInfosTechniques();
        }
    }
}
