using System;
namespace AbstractFactory
{
    public class FabriqueVehiculeElectrique: FabriqueVehicule
    {
        public Automobile CreeAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new AutomobileElectrique(modele, couleur, puissance, espace);
        }

        public Scooter CreeScooter(string modele, string couleur, int puissance)
        {
            return new ScooterElectrique(modele, couleur, puissance);
        }
    }
}
