using System;
namespace ChainOfResponsability
{
    public class Modele : ObjetBase
    {
        protected string laDescription;

        protected string nom;

        public Modele(string nom, string description)
        {
            laDescription = description;
            this.nom = nom;
        }

        protected override string description
        {
            get
            {
                if (laDescription != null)
                {
                    return $"Modele {nom} : {laDescription}";
                }
                else
                    return null;
            }
        }
    }
}
