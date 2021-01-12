using System;
namespace ReflectiveVisitor
{
    public abstract class Societe : Visitable
    {
        public string nom { get; protected set; }
        public string email { get; protected set; }
        public string adresse { get; protected set; }

        public Societe(string nom, string email, string adresse)
        {
            this.nom = nom;
            this.email = email;
            this.adresse = adresse;
        }

        public abstract bool ajouteFiliale(Societe filiale);
    }
}
