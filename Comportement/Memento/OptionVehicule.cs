using System;
using System.Collections.Generic;
namespace Memento
{
    public class OptionVehicule
    {
        protected string nom;
        public IList<OptionVehicule> optionsIncompatibles { get; protected set; }

        public OptionVehicule(string nom)
        {
            optionsIncompatibles = new List<OptionVehicule>();
            this.nom = nom;
        }

        public void ajoutOptionIncompatible(
            OptionVehicule optionIncompatible)
        {
            if (!optionsIncompatibles.Contains(optionIncompatible))
            {
                optionsIncompatibles.Add(optionIncompatible);
                optionIncompatible.ajoutOptionIncompatible(this);
            }
        }

        public void affiche()
        {
            Console.WriteLine($"Option : {nom}");
        }
    }
}
