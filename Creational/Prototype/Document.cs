using System;
namespace Prototype
{
    public abstract class Document
    {
        protected string Content = "";

        public Document Duplicate()
        {
            Document result;
            result = (Document)this.MemberwiseClone();
            return result;
        }

        public void FillOut (string informations)
        {
            Content = informations;
        }

        public abstract void Print();
        public abstract void Display();
    }
}
