using System;
using System.Collections.Generic;
namespace Memento
{
    public class ChariotOption
    {
        protected IList<OptionVehicule> options =
            new List<OptionVehicule>();

        public Memento ajouteOption(OptionVehicule optionVehicule)
        {
            var resultat = new MementoImpl();
            resultat.etat = options;
            var optionsIncompatibles = optionVehicule.optionsIncompatibles;
            foreach (var opt in optionsIncompatibles)
            {
                options.Remove(opt);
            }
            options.Add(optionVehicule);
            return resultat;

        }

        public void annule(Memento memento)
        {
            var mementoImplInstance = memento as MementoImpl;
            if (mementoImplInstance == null)
                return;
            options = mementoImplInstance.etat;
        }

        public void affiche()
        {
            Console.WriteLine("Contenu du chariot des options");
            foreach (var option in options)
                option.affiche();
            Console.WriteLine();
        }
    }
}
