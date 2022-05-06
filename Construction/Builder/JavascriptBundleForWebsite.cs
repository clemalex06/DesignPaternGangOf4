using System;
namespace Builder
{
    public class JavascriptBundleForWebsite : BundleForWebsite
    {
        public JavascriptBundleForWebsite()
        {
            bundle = new JavascriptBundle();
        }

        public override void ApplyBundleForHighcharts(string webSiteName)
        {
            string document = $"<script>Highcharts's JAVASCRIPT applied for '{webSiteName}' website</script>";
            bundle.AddDocument(document);
        }

        public override void ApplyBundleForBootstrap(string webSiteName)
        {
            string document = $"<script>Bootstrap's JAVASCRIPT applied for '{webSiteName}' website</script>";
            bundle.AddDocument(document);
        }
    }
}
