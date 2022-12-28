using System;
namespace Builder
{
    public class Website
    {
        protected BundleForWebsite BundleForWebsite;
        public Website(BundleForWebsite bundleForWebsite)
        {
            this.BundleForWebsite = bundleForWebsite;
        }

        public Bundle InitializeBundleContent(string webSiteName)
        {
            Console.WriteLine($"new bundle intialized for '{webSiteName}' website");
            BundleForWebsite.ApplyBundleForHighcharts(webSiteName);
            BundleForWebsite.ApplyBundleForBootstrap(webSiteName);
            return BundleForWebsite.Bundle();
        }
    }
}
