using System;
namespace Builder
{
    public class LiasseHtml:Liasse
    {
        public override void ajouteDocument(string document)
        {
            if (document.StartsWith("<html>"))

            {
                contenu.Add(document);
            }
        }

        public override void imprime()
        {
            Console.WriteLine("Liasse html");
             foreach(var s in contenu)
            {
                Console.WriteLine(s);
            }
        }
    }
}
