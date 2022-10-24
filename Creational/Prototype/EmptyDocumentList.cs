using System.Collections.Generic;
namespace Prototype
{
    public class EmptyDocumentList : DocumentList
    {
        private static EmptyDocumentList _instance;

        private EmptyDocumentList()
        {
            documents = new List<Document>();
        }

        public static EmptyDocumentList Instance()
        {
            if (_instance == null)
                _instance = new EmptyDocumentList();
            return _instance;
        }

        public void Add(Document doc)
        {
            documents.Add(doc);
        }

        public void Remove(Document doc)
        {
            documents.Remove(doc);
        }
    }
}
