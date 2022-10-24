using System;
namespace Visitor
{
    public class SocieteSansFiliale : Societe
    {
        public SocieteSansFiliale(string nom, string email, string adresse)
            :base(nom,email,adresse)
        {
        }

        public override void accepteVisiteur(Visiteur visiteur)
        {
            visiteur.visite(this);
        }

        public override bool ajouteFiliale(Societe filiale)
        {
            return false;
        }
    }
}
