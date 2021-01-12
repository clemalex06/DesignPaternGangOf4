using System;
namespace AbstractFactory
{
    public abstract class Scooter
    {
        protected string modele;
        protected string couleur;
        protected int puissance;

        public Scooter(string modele, string couleur, int puissance)
        {
            this.modele = modele;
            this.puissance = puissance;
            this.couleur = couleur;
        }

        public abstract void afficheCaracteristique();
    }
}
