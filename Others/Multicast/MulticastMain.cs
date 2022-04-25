using System;

namespace Multicast
{
    /*
     *
     * Concept du Multicast
     * gérer les évènements produits dans un programme afin de les transmettre
     * à un ensemble de récepteurs concernés. Le pattern est basé sur un mécanisme
     * d'inscription des récepteurs auprès des expéditeurs
     * 
     */
    public static class MulticastMain
    {
        public static void Main()
        {
            var directionGenerale = new DirectionGenerale();
            var directionCommerciale = new DirectionCommerciale();
            var commercial1 = new Commercial("Paul");
            var commercial2 = new Commercial("Henri");

            var administratif = new Administratif("Jacques");

            directionGenerale.ajouteRecepteurGeneral(commercial1);
            directionGenerale.ajouteRecepteurGeneral(commercial2);
            directionGenerale.ajouteRecepteurGeneral(administratif);

            directionCommerciale.ajouteRecepteurCommercial(commercial1);
            directionCommerciale.ajouteRecepteurCommercial(commercial2);

            directionGenerale.envoieMessages();
            directionCommerciale.envoieMessages();
        }
    }
}
