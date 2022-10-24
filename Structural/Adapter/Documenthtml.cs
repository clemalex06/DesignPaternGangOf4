using System;
namespace Adapter
{
    public class Documenthtml:Document
    {
        protected string _content;

        public string Content {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
            }
        }

        public void Draw()
        {
            Console.WriteLine($"Draw document Html : {Content}");
        }

        public void Print()
        {
            Console.WriteLine($"Print document Html : {Content}");
        }
    }
}
