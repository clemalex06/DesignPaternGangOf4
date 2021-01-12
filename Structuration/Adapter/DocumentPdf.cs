using System;
namespace Adapter
{
    public class DocumentPdf : Document
    {

        protected ComposantPdf outilPdf = new ComposantPdf();

        public string contenu
        {
            set
            {
                outilPdf.pdfFixeContenu(value);
            }
        }

        public void dessine()
        {
            outilPdf.prepareAffichage();
            outilPdf.pdfRaffraichit();
            outilPdf.pdfTermineAffichage();
        }

        public void imprime()
        {
            outilPdf.pdfEnvoiImprimante();
        }
    }
}
