using System;
namespace Builder
{
    public class ConstructeurLiasseVehiculePdf:ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculePdf()
        {
            liasse = new LiassePdf();
        }

        public override void construitBondeCommande(string nomlient)
        {
            string document = $"<pdf>Bon de commande pour le client {nomlient}</pdf>";
            liasse.ajouteDocument(document);
        }

        public override void construitDemandeImmatriculation(string nomDemandeur)
        {
            string document = $"<pdf>Demande d'immatriculation pour le demandeur {nomDemandeur}</pdf>";
            liasse.ajouteDocument(document);
        }
    }
}
