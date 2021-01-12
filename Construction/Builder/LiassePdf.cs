using System;
namespace Builder
{
    public class LiassePdf:Liasse
    {
        public override void ajouteDocument(string document)
        {
            if (document.StartsWith("<pdf>"))

            {
                contenu.Add(document);
            }
        }

        public override void imprime()
        {
            Console.WriteLine("Liasse pdf");
            foreach (var s in contenu)
            {
                Console.WriteLine(s);
            }
        }
    }
}
