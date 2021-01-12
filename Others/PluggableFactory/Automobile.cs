using System;
namespace PluggableFactory
{
    public abstract class Automobile
    {
        public string modele { get; set; }
        public string couleur { get; set; }
        public int puissance { get; set; }
        public double espace { get; set; }

        public Automobile duplique()
        {
            Automobile resultat;
            resultat = (Automobile)this.MemberwiseClone();
            return resultat;
        }

        public abstract void afficheCaracteristiques();
    }
}
