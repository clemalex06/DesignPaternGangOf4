using System;

namespace Prototype
{
    /*
     *
     * Concept du prototype
     * permet la creation de nouveaux objets par duplication
     * d'objets existants appelés prototypes qui disposent
     * de la capacité de clonage 
     * 
     */
    public static class PrototypeMain
    {
        public static void Main()
        {
            LiasseVierge liasseVierge = LiasseVierge.Instance();

            liasseVierge.ajoute(new BonDeCommande());
            liasseVierge.ajoute(new CertificatSession());
            liasseVierge.ajoute(new DemandeImmatriculation());

            LiasseClient liasseClient1 = new LiasseClient("Martin");
            LiasseClient liasseClient2 = new LiasseClient("Durant");

            liasseClient1.affiche();
            liasseClient2.affiche();
        }
    }
}
