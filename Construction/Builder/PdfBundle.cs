using System;
namespace Builder
{
    public class PdfBundle : Bundle
    {
        public override void AddDocument(string document)
        {
            if (document.StartsWith("<pdf>"))

            {
                content.Add(document);
            }
        }

        public override void Print()
        {
            Console.WriteLine("PDF bundle");
            foreach (var s in content)
            {
                Console.WriteLine(s);
            }
        }
    }
}
