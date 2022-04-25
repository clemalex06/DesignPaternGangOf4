using System;

namespace Decorator
{
    /*
     *
     * Permet d'ajouter dynamiquement des fonctionnalités supplémentaires
     * à un objet 
     * 
     */
    public static class DecoratorMain
    {
        public static void Main()
        {
            var vueVehicule = new VueVehicule();
            var modeleDecorateur = new ModeleDecorateur(vueVehicule);
            var marqueDecorateur = new MarqueDecorateur(modeleDecorateur);
            marqueDecorateur.affiche();
        }
    }
}
