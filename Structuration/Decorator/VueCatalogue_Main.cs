using System;

namespace Decorator
{
    /*
     *
     * Permet d'ajouter dynamiquement des fonctionnalités supplémentaires
     * à un objet 
     * 
     */
    public class VueCatalogue
    {
        public static void Main(string[] args)
        {
            var vueVehicule = new VueVehicule();
            var modeleDecorateur = new ModeleDecorateur(vueVehicule);
            var marqueDecorateur = new MarqueDecorateur(modeleDecorateur);
            marqueDecorateur.affiche();
        }
    }
}
