using System;

namespace PluggableFactory
{
    /*
     *
     *Concept du pluggable Factory
     * Abstract Factory + Prototype
     * 
     */
    public static class PluggableFactoryMain
    {
        public static void Main()
        {
            var protoAutoStandardBleu = new AutomobileElectricite();
            protoAutoStandardBleu.modele = "standard";
            protoAutoStandardBleu.couleur = "bleu";

            var protoScooterClassicRouge = new ScooterEssence();
            protoScooterClassicRouge.modele = "classique";
            protoScooterClassicRouge.couleur = "rouge";

            var fabrique = new fabriqueVehicule();
            fabrique.prototypeAutomobile = protoAutoStandardBleu;
            fabrique.prototypeScooter = protoScooterClassicRouge;

            var auto = fabrique.creerAutomobile();
            auto.afficheCaracteristiques();

            var scooter = fabrique.creerScooter();
            scooter.afficheCaracteristiques();
        }
    }
}
