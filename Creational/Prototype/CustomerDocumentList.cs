using System.Collections.Generic;
namespace Prototype
{
    public class CustomerDocumentList : DocumentList
    {
        public CustomerDocumentList(string informations)
        {
            documents = new List<Document>();
            EmptyDocumentList emptyDocumentList = EmptyDocumentList.Instance();
            IList<Document> emptyDocuments = emptyDocumentList.documents;

            foreach (var doc in emptyDocuments)
            {
                Document copieDocument = doc.Duplicate();
                copieDocument.FillOut(informations);
                documents.Add(copieDocument);
            }
        }

        public void Display()
        {
            foreach (var doc in documents)
                doc.Display();
        }

        public void Print()
        {
            foreach (var doc in documents)
                doc.Print();
        }
    }
}
