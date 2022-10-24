using System;
namespace Iterator
{
    public class CatalogueVehicule:Catalogue<Vehicule,IterateurVehicule>
    {
        public CatalogueVehicule()
        {
            contenu.Add(new Vehicule("vehicule bon marche"));
            contenu.Add(new Vehicule("petit vehicule bon marche"));
            contenu.Add(new Vehicule("vehicule grande qualite"));
        }
    }
}
