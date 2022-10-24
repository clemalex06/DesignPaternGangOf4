using System;

namespace Observer
{
    /*
     *
     * Concept de l'adapter
     * construit une dépdendance entre un sujet et des observateurs de façon à ce que
     * chaque modification du sujet soit notifiée aux observateurs
     * afin qu'ils puissent mettre à jour leurs état
     * 
     */
    public class ObserverMain
    {
        public static void Main()
        {
            var vehicule = new Vehicule();
            vehicule.description = "vehicule bon marche";
            vehicule.prix = 5000;
            var vueVehicule = new VueVehicule(vehicule);
            vueVehicule.redessine();
            vehicule.prix = 4500;
            var vueVehicule2 = new VueVehicule(vehicule);
            vehicule.prix = 5500;
        }
    }
}
