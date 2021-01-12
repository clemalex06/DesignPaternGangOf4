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
    public class Client
    {
        public static void Main(string[] args)
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
