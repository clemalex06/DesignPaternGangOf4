using System;
namespace Builder
{
    public class HtmlBundle : Bundle
    {
        public override void AddDocument(string document)
        {
            if (document.StartsWith("<html>"))

            {
                content.Add(document);
            }
        }

        public override void Print()
        {
            Console.WriteLine("HTML Bundle");
            foreach (var s in content)
            {
                Console.WriteLine(s);
            }
        }
    }
}
