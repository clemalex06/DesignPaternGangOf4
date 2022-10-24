namespace ChainOfResponsability
{
    public abstract class BaseObject
    {
        public BaseObject Next { protected get; set; }

        private string DefaultDescription()
        {
            return "Defaut Description";
        }

        protected abstract string Description { get; }

        public string Describe()
        {
            string result = Description;

            if (result != null)
            {
                return result;
            }

            if (Next != null)
                return Next.Describe();
            else
                return DefaultDescription();
        }
    }
}
