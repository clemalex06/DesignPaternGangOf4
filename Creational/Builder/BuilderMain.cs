using System;
namespace Builder
{
    /*
     * Builder's Concept :
     * Allows the construction of complex objects to be separated from their layout, 
     * so that a client can create these complex objects with different layouts.
     */

    public static class BuilderMain
    {
        public static void Main()
        {
            BundleForWebsite bundleForWebsite;
            Console.WriteLine(" Hello Developer : do you want to use 'JAVASCRIPT' Bundles(1) or 'CSS' Bundles(Default) for your website??");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                bundleForWebsite = new JavascriptBundleForWebsite();
            }
            else
            {
                bundleForWebsite = new CssBundleForWebsite();
            }

            var website = new Website(bundleForWebsite);
            Bundle bundle = website.InitializeBundleContent("Linkedin");
            bundle.DisplayBundleContent();
        }
    }
}
