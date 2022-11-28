namespace Iterator
{
    public class CarCatalog : Catalog<Car, CarIterator>
    {
        public CarCatalog()
        {
            Content.Add(new Car("cheap car"));
            Content.Add(new Car("small cheap car"));
            Content.Add(new Car("Big quality car"));
            Content.Add(new Car("Expensive car"));
            Content.Add(new Car("family car"));
            Content.Add(new Car("Electric car"));
        }
    }
}
