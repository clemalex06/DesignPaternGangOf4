using System;
using System.Collections.Generic;

namespace Builder
{
    public abstract class Bundle
    {
        protected IList<string> content = new List<string>();

        public abstract void AddDocument(string document);
        public abstract void Print();
    }
}
