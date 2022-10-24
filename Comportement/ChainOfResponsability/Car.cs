namespace ChainOfResponsability
{
    public class Car : BaseObject
    {
        protected string CarDescription;

        public Car(string description)
        {
            CarDescription = description;
        }

        protected override string Description
        {
            get
            {
                return CarDescription;
            }
        }
    }
}
