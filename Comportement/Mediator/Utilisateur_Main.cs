using System;

namespace Mediator
{
    /*
     *
     * Concept du Mediator
     * construit un objet dont la vocation est la gestion
     * et le controle des interactions au sein d'un ensemble d'objets sans
     * que ces éléments se connaissent mutuellement
     * 
     */
    public class Utilisateur
    {
        public static void Main(string[] args)
        {
            var formulaire = new Formulaire();
            formulaire.ajouteControle(new ZoneSaisie("Nom"));
            formulaire.ajouteControle(new ZoneSaisie("Prenom"));
            var menu = new PopupMenu("Coemprunteur");
            menu.ajouteOption("sans coemprunteur");
            menu.ajouteOption("avec coemprunteur");
            formulaire.ajouteControle(menu);
            formulaire.menuCoemprunteur = menu;
            var bouton = new Bouton("OK");
            formulaire.ajouteControle(bouton);
            formulaire.boutonOk = bouton;
            formulaire.ajouteControleCoemprunteur(
                new ZoneSaisie("Nom du coemprunteur"));
            formulaire.ajouteControleCoemprunteur(
                new ZoneSaisie("Prenom du coemprunteur"));
            formulaire.saisie();

        }
    }
}
