using System;

namespace Visitor
{
    /*
     *
     *Concept du Visitor
     * construit une opération à réaliser sur les éléments d'un ensemble
     * d'objets. De nouvelles opérations peuvent ainsi être ajoutées
     * sans modifier les classes de ces objets
     * 
     */
    public static class VisitorMain
    {
        public static void Main()
        {
            var societe1 = new SocieteSansFiliale("societe1",
                "info@societe1.com", "rue de la societe1");
            var societe2 = new SocieteSansFiliale("societe2",
                "info@societe2.com", "rue de la societe2");
            var societe3 = new SocieteSansFiliale("societe3",
                "info@societe3.com", "rue de la societe3");

            var groupe1 = new SocieteMere("groupe1", "info@group1.com",
                "rue du groupe1");
            var groupe2 = new SocieteMere("groupe2", "info@group2.com",
                "rue du groupe2");

            groupe1.ajouteFiliale(societe1);
            groupe1.ajouteFiliale(societe2);
            groupe2.ajouteFiliale(groupe1);
            groupe2.ajouteFiliale(societe3);
            groupe2.accepteVisiteur(new VisiteurMailingCommercial());
        }
    }
}
