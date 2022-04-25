using System;

namespace ReflectiveVisitor
{
    /*
     *
     * Concept du reflective Visitor :
     * Visitor + Composite
     * 
     */
    public static class ReflectiveVisitorMain
    {
        public static void Main()
        {
            var societe1 = new SocieteSansFiliale("societe1",
                "info@societe1.com,", "rue de la societe1");
            var societe2 = new SocieteSansFiliale("societe2",
                "info@societe2.com,", "rue de la societe2");
            var societe3 = new SocieteSansFiliale("societe3",
                "info@societe3.com,", "rue de la societe3");
            var groupe1 = new SocieteMere("groupe1",
                "info@groupe1.com,", "rue de la groupe1");
            var groupe2 = new SocieteMere("groupe2",
                "info@groupe2.com,", "rue de la groupe2");

            groupe1.ajouteFiliale(societe1);
            groupe1.ajouteFiliale(societe2);

            groupe2.ajouteFiliale(groupe1);
            groupe2.ajouteFiliale(societe3);

            new VisiteurMailingCommercial().demarreVisite(groupe2);
        }
    }
}
