using System;
namespace PluggableFactory
{
    public abstract class Scooter
    {
        public string modele { get; set; }
        public string couleur { get; set; }
        public int puissance { get; set; }

        public Scooter duplique()
        {
            Scooter resultat;
            resultat = (Scooter)this.MemberwiseClone();
            return resultat;
        }

        public abstract void afficheCaracteristiques();
    }
}
