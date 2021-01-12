using System.Collections.Generic;
namespace Prototype
{
    public class LiasseClient:Liasse
    {
        public LiasseClient(string informations)
        {
            documents = new List<Document>();
            LiasseVierge laLiassevIerge = LiasseVierge.Instance();
            IList<Document> documentsVierges = laLiassevIerge.documents;

            foreach (var doc in documentsVierges)
            {
                Document copieDocument = doc.duplique();
                copieDocument.remplit(informations);
                documents.Add(copieDocument);
            }
        }

        public void affiche()
        {
            foreach (var doc in documents)
                doc.affiche();
        }

        public void imprime()
        {
            foreach (var doc in documents)
                doc.imprime();
        }
    }
}
