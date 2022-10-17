using System;
namespace Builder
{
    public class JavascriptBundle : Bundle
    {
        public override void AddDocument(string document)
        {
            if (document.StartsWith("<script>") )

            {
                content.Add(document);
            }
        }

        public override void DisplayBundleContent()
        {
            Console.WriteLine("JAVASCRIPT Bundles");
            foreach (var s in content)
            {
                Console.WriteLine(s);
            }
        }
    }
}
