using System;
namespace Builder
{
    public class CssBundle : Bundle
    {
        public override void AddDocument(string document)
        {
            if (document.StartsWith("<style>"))

            {
                content.Add(document);
            }
        }

        public override void DisplayBundleContent()
        {
            Console.WriteLine("CSS Bundles");
            foreach (var s in content)
            {
                Console.WriteLine(s);
            }
        }
    }
}
