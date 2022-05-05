namespace Builder
{
    public abstract class BundleForVehicule

    //BundleOf
    {
        protected Bundle bundle;

        public abstract void MakePurchaseOrder(string customerName);

        public abstract void ApplyForRegistration(string requesterName);

        public Bundle Result()
        {
            return bundle;
        }
    }
}
