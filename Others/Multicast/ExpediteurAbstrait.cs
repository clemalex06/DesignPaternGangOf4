using System;
using System.Collections.Generic;

namespace Multicast
{
    public abstract class ExpediteurAbstrait<TMessage, TRecepteur>
        where TMessage:MessageAbstrait
        where TRecepteur:RecepteurAbstrait<TMessage>
    {
        protected IList<TRecepteur> registre = new List<TRecepteur>();

        public void ajoute(TRecepteur recepteur)
        {
            registre.Add(recepteur);
        }

        public void envoieMultiple(TMessage message)
        {
            foreach (var recpt in registre)
                recpt.recoit(message);
        }
    }
}
