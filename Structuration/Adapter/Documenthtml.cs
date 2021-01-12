using System;
namespace Adapter
{
    public class Documenthtml:Document
    {
        protected string _contenu;

        public string contenu {
            get
            {
                return _contenu;
            }
            set
            {
                _contenu = value;
            }
        }

        public void dessine()
        {
            Console.WriteLine($"Dessine document Html : {contenu}");
        }

        public void imprime()
        {
            Console.WriteLine($"Imprime document Html : {contenu}");
        }
    }
}
