using System;
namespace ReflectiveVisitor
{
    public class SocieteSansFiliale : Societe
    {
        public SocieteSansFiliale(string nom, string email,
           string adresse ):base(nom,email,adresse)
        {
        }

        public override bool ajouteFiliale(Societe filiale)
        {
            return false;
        }
    }
}
