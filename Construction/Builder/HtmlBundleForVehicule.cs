using System;
namespace Builder
{
    public class HtmlBundleForVehicule : BundleForVehicule
    {
        public HtmlBundleForVehicule()
        {
            bundle = new HtmlBundle();
        }

        public override void MakePurchaseOrder(string requesterName)
        {
            string document = $"<html>Purchase Order for : {requesterName}</html>";
            bundle.AddDocument(document);
        }

        public override void ApplyForRegistration(string requesterName)
        {
            string document = $"<html>Registration for :  {requesterName}</html>";
            bundle.AddDocument(document);
        }
    }
}
