using System;
using System.Collections.Generic;

namespace Iterator
{
    public abstract class Iterator<TElement> where TElement : Element
    {
        public string KeyWordRequest { protected get; set; }
        protected int Index;
        public IList<TElement> Content { protected get; set; }

        public void Start()
        {
            Index = 0;
            int length = Content.Count;
            while ((Index < length) &&
                (!Content[Index].IsValidKeyWord(KeyWordRequest)))
                Index++;
        }

        public void Next()
        {
            int length = Content.Count;
            Index++;
            while ((Index < length) &&
                (!Content[Index].IsValidKeyWord(KeyWordRequest)))
                Index++;
        }

        public TElement Item()
        {
            if (Index < Content.Count)
                return Content[Index];
            else
                return null;
        }
    }
}
