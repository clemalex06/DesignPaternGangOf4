using System;
using System.Collections.Generic;

namespace Multicast
{
    public class DirectionGenerale
    {
        protected ExpediteurGeneral expediteurGeneral =
            new ExpediteurGeneral();

        public void envoieMessages()
        {
            IList<string> contenu = new List<string>();
            contenu.Add("Informations generales");
            contenu.Add("Informations specifiques");
            var message = new MessageGeneral(contenu);
            expediteurGeneral.envoieMultiple(message);
        }

        public void ajouteRecepteurGeneral(Employe recepteur)
        {
            expediteurGeneral.ajoute(recepteur);
        }
    }
}
