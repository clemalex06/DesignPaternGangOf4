using System;
namespace Builder
{
    public class ConstructeurLiasseVehiculeHtml:ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeHtml()
        {
            liasse = new LiasseHtml();
        }

        public override void construitBondeCommande(string nomlient)
        {
            string document = $"<html>Bon de commande pour le client {nomlient}</html>";
            liasse.ajouteDocument(document);
        }

        public override void construitDemandeImmatriculation(string nomDemandeur)
        {
            string document = $"<html>Demande d'immatriculation pour le demandeur {nomDemandeur}</html>";
            liasse.ajouteDocument(document);
        }
    }
}
