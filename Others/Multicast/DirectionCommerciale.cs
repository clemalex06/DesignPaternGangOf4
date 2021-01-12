using System;
namespace Multicast
{
    public class DirectionCommerciale
    {
        protected ExpediteurCommercial expediteurCommercial =
            new ExpediteurCommercial();

        public void envoieMessages()
        {
            var message = new MessageCommercial("Annonce nouvelle gamme");
            expediteurCommercial.envoieMultiple(message);
            message = new MessageCommercial("Annonce suppression modele");
            expediteurCommercial.envoieMultiple(message);
        }

        public void ajouteRecepteurCommercial(RecepteurCommercial recepteur)
        {
            expediteurCommercial.ajoute(recepteur);
        }


    }
}
