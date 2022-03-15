using System;

namespace FlighWeight
{
    /*
     *
     *Concept du FlyWeight
     * facilite le partage d'un ensemble importants
     * d'objets dont le grain est fin
     * 
     */
    public static class FlighWeightMain
    {
        public static void Main()
        {
            var fabrique = new FabriqueOption();
            VehiculeCommande vehicule = new VehiculeCommande();
            vehicule.ajouteOptions("airbag", 80, fabrique);
            vehicule.ajouteOptions("direction assitee", 90, fabrique);
            vehicule.ajouteOptions("vitres electriques", 85, fabrique);
            vehicule.afficheOptions();
        }
    }
}
