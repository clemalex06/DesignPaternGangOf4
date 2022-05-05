namespace Builder
{
    public class SalesMan
    {
        protected BundleForVehicule vehiculeBundle;
        public SalesMan(BundleForVehicule vehiculeBundle)
        {
            this.vehiculeBundle = vehiculeBundle;
        }

        public Bundle Build(string customerName)
        {
            vehiculeBundle.MakePurchaseOrder(customerName);
            vehiculeBundle.ApplyForRegistration(customerName);
            return vehiculeBundle.Result();
        }
    }
}
