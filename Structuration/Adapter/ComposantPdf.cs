using System;
namespace Adapter
{
    public class ComposantPdf
    {
        protected string contenu;

        public void pdfFixeContenu(string contenu)
        {
            this.contenu = contenu;
        }

        public void prepareAffichage()
        {
            Console.WriteLine("Affichage PDF : debut");
        }

        public void pdfRaffraichit()
        {
            Console.WriteLine($"Affichage contenu PDF : {contenu}");
        }

        public void pdfTermineAffichage()
        {
            Console.WriteLine("Affichage PDF: fin");
        }

        public void pdfEnvoiImprimante()
        {
            Console.WriteLine($"Impression PDF : {contenu}");
        }
    }
}
