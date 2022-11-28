namespace Iterator
{
    /*
     * Iterator's Concept :	 
     * Lets you traverse elements of a collection 
     * without exposing its underlying representation (list, stack, tree, etc.).
     */
    public static class IteratorMain
    {
        public static void Main()
        {
            var catalog = new CarCatalog();
            var iterator = catalog.Search("cheap");
            Car car;
            iterator.Start();
            car = iterator.Item();
            while (car != null)
            {
                car.Display();
                iterator.Next();
                car = iterator.Item();
            }
        }
    }
}
