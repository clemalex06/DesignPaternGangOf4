using System;
namespace AbstractFactory
{
    public interface FabriqueVehicule
    {
        Automobile CreeAutomobile(string modele, string couleur, int puissance, double espace);
        Scooter CreeScooter(string modele, string couleur, int puissance);
    }
}
