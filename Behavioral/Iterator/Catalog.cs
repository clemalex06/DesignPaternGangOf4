using System.Collections.Generic;
namespace Iterator
{
    public abstract class Catalog<TELement, TIterator>
        where TELement : Element
        where TIterator : Iterator<TELement>, new()
    {
        protected IList<TELement> Content = new List<TELement>();

        public TIterator Search(string keyWordRequest)
        {
            TIterator result = new TIterator();
            result.KeyWordRequest = keyWordRequest;
            result.Content = Content;
            return result;
        }
    }
}
