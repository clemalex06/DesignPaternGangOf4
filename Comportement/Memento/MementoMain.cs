using System;

namespace Memento
{
    /*
     *
     * Concept du memento :
     * sauvegarde et restaure l'etat d'un objet
     * 
     */
    public static class MementoMain
    {
        public static void Main()
        {
            Memento memento;
            var option1 = new OptionVehicule("Sieges en cuir");
            var option2 = new OptionVehicule("Accoudoirs");
            var option3 = new OptionVehicule("sieges sprotifs");

            option1.ajoutOptionIncompatible(option3);
            option2.ajoutOptionIncompatible(option3);

            var chariotOptions = new ChariotOption();
            chariotOptions.ajouteOption(option1);
            chariotOptions.ajouteOption(option2);
            chariotOptions.affiche();
            memento = chariotOptions.ajouteOption(option3);
            chariotOptions.affiche();
            chariotOptions.annule(memento);
            chariotOptions.affiche();
        }
    }
}
