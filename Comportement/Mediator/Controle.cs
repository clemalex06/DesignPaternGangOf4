using System;
namespace Mediator
{
    public abstract class Controle
    {
        public string valeur { get; protected set; }
        public Formulaire directeur { get; set; }
        public string nom { get; protected set; }

        public Controle(string nom)
        {
            this.nom = nom;
            this.valeur = "";
        }

        public abstract void saisie();
        protected void modifie()
        {
            directeur.controleModifie(this);
        }
    }
}
