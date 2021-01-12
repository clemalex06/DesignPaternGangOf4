using System;
namespace ChainOfResponsability
{
    public abstract class ObjetBase
    {
        public ObjetBase suivant { protected get; set; }

        private string descriptionParDefault()
        {
            return "description par defaut";
        }

        protected abstract string description { get; }

        public string donneDescription()
        {
            string resultat;
            resultat = this.description;

            if (resultat!= null)
            {
                return resultat;
            }

            if (suivant != null)
                return suivant.donneDescription();
            else
                return this.descriptionParDefault();
        }
    }
}
