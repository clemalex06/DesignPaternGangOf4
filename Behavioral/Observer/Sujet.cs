using System;
using System.Collections.Generic;
namespace Observer
{
    public abstract class Sujet
    {
        protected IList<Observateur> observateurs = new List<Observateur>();

        public void ajoute(Observateur observateur)
        {
            observateurs.Add(observateur);
        }

        public void retire(Observateur observateur)
        {
            observateurs.Remove(observateur);
        }

        public void notifie()
        {
            foreach (var observateur in observateurs)
                observateur.actualise();
        }
    }
}
