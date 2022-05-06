using System;

namespace Builder
{
    public class Website
    {
        protected BundleForWebsite bundleForWebsite;
        public Website(BundleForWebsite bundleForWebsite)
        {
            this.bundleForWebsite = bundleForWebsite;
        }

        public Bundle InitializeBundleContent(string webSiteName)
        {
            Console.WriteLine($"new bundle intialized for '{webSiteName}' website");
            bundleForWebsite.ApplyBundleForHighcharts(webSiteName);
            bundleForWebsite.ApplyBundleForBootstrap(webSiteName);
            return bundleForWebsite.Bundle();
        }
    }
}
