namespace Builder
{
    public abstract class BundleForWebsite
    {
        protected Bundle bundle;

        public abstract void ApplyBundleForHighcharts(string webSiteName);

        public abstract void ApplyBundleForBootstrap(string webSiteName);

        public Bundle Bundle()
        {
            return bundle;
        }
    }
}
