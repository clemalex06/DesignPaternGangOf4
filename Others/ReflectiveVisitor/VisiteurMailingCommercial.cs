using System;
namespace ReflectiveVisitor
{
    public class VisiteurMailingCommercial : Visiteur, VisiteurSociete
    {
        public void visite(SocieteSansFiliale societe)
        {
            Console.WriteLine($"Envoi d'un email a {societe.nom}" +
                $" adresse : {societe.email}" +
                $" Proposition commerciale pour votre societe");
        }

        public void visite(SocieteMere societe)
        {
            Console.WriteLine($"Envoi d'un email a {societe.nom}" +
                $" adresse : {societe.email}" +
                $" Proposition commerciale pour votre groupe");
            Console.WriteLine($"Impression d'un courrier a {societe.nom}" +
                $" adresse : {societe.adresse}" +
                $" Proposition commerciale pour votre groupe");
            foreach (var soc in societe.filiales)
                this.demarreVisite(soc);
        }
    }
}
