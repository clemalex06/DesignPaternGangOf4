using System.Collections.Generic;
namespace Prototype
{
    public abstract class DocumentList
    {
        public IList<Document> documents { get; protected set; }
    }
}
