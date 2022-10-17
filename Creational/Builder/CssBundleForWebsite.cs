namespace Builder
{
    public class CssBundleForWebsite : BundleForWebsite
    {
        public CssBundleForWebsite()
        {
            bundle = new CssBundle();
        }

        public override void ApplyBundleForHighcharts(string webSiteName)
        {
            string document = $"<style>Highcharts's CSS applied for '{webSiteName}' website</style>";
            bundle.AddDocument(document);
        }

        public override void ApplyBundleForBootstrap(string webSiteName)
        {
            string document = $"<style>Bootstrap's CSS applied for '{webSiteName}' website</style>";
            bundle.AddDocument(document);
        }
    }
}
