namespace Builder
{
    public class PdfBundleForVehicule : BundleForVehicule
    {
        public PdfBundleForVehicule()
        {
            bundle = new PdfBundle();
        }

        public override void MakePurchaseOrder(string requesterName)
        {
            string document = $"<pdf>Purchase Order for : {requesterName}</pdf>";
            bundle.AddDocument(document);
        }

        public override void ApplyForRegistration(string requesterName)
        {
            string document = $"<pdf>Registrationr for :  {requesterName}</pdf>";
            bundle.AddDocument(document);
        }
    }
}
