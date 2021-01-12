using System;
using System.Collections.Generic;
namespace Mediator
{
    public class Formulaire
    {
        protected IList<Controle> controles = new List<Controle>();
        protected IList<Controle> controlesCoemprunteur =
            new List<Controle>();
        public PopupMenu menuCoemprunteur { protected get; set; }
        public Bouton boutonOk { protected get; set; }
        protected bool enCours = true;

        public void ajouteControle(Controle controle)
        {
            controles.Add(controle);
            controle.directeur = this;
        }

        public void ajouteControleCoemprunteur(Controle controle)
        {
            controlesCoemprunteur.Add(controle);
            controle.directeur = this;
        }

        public void controleModifie(Controle controle)
        {
            if (controle == menuCoemprunteur)
            {
                if (controle.valeur == "avec coemprunteur")
                {
                    foreach (var cont in controlesCoemprunteur)
                    {
                        cont.saisie();
                    }
                }
            }
            if (controle == boutonOk)
            {
                enCours = false;
            }
        }

        public void saisie()
        {
            while (true)
            {
                foreach (var controle in controles)
                {
                    controle.saisie();
                    if (!enCours)
                        return;
                }
            }
        }
    }
}
