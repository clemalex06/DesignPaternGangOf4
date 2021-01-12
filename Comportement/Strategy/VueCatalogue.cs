using System;
using System.Collections.Generic;

namespace Strategy
{
    public class VueCatalogue
    {
        protected IList<VueVehicule> contenu =
            new List<VueVehicule>();

        protected DessinCatalogue dessin;

        public VueCatalogue(DessinCatalogue dessin)
        {
            contenu.Add(new VueVehicule("Vehicule bon marche"));
            contenu.Add(new VueVehicule("Vehicule Spacieux"));
            contenu.Add(new VueVehicule("Vehicule rapide"));
            contenu.Add(new VueVehicule("Vehicule confortable"));
            contenu.Add(new VueVehicule("Vehicule sportif"));

            this.dessin = dessin;
        }

        public void dessine()
        {
            dessin.dessine(contenu);
        }
    }
}
