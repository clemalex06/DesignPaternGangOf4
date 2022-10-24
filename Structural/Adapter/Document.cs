using System;
namespace Adapter
{
    public interface Document
    {
        string Content { set;}
        void Draw();
        void Print();
    }
}
