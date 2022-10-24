namespace ChainOfResponsability
{
    public class CarBrand : BaseObject
    {
        protected string Description1, Description2, Name;
        public CarBrand(string name, string description1, string description2)
        {
            Description1 = description1;
            Description2 = description2;
            Name = name;
        }

        protected override string Description
        {
            get
            {
                if ((Description1 != null) && (Description2 != null))
                {
                    return $"Car Brand {Name} : description1 => {Description1}, description2 => {Description2}";
                }
                else if (Description1 != null)
                {
                    return $"Car Brand {Name} : description1 => {Description1}";
                }
                else
                    return null;
            }
        }
    }
}
