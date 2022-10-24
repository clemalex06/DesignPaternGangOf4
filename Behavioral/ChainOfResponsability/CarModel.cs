namespace ChainOfResponsability
{
    public class CarModel : BaseObject
    {
        protected string ModelDescription;

        protected string Name;

        public CarModel(string name, string description)
        {
            ModelDescription = description;
            Name = name;
        }

        protected override string Description
        {
            get
            {
                if (ModelDescription != null)
                {
                    return $"Car Model {Name} : {ModelDescription}";
                }
                else
                    return null;
            }
        }
    }
}
