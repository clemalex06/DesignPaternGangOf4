namespace FlighWeight
{
    /*
     * FlighWeight's Concept :
     * Lets you fit more objects into the available amount of RAM 
     * by sharing common parts of state between multiple objects instead of keeping all of the data in each object.
     */
    public static class FlighWeightMain
    {
        public static void Main()
        {
            var fabrique = new OptionsFactory();
            CarOrder car = new CarOrder();
            car.AddOption("airbag", 80, fabrique);
            car.AddOption("power steering", 90, fabrique);
            car.AddOption("electric windows", 85, fabrique);
            car.DisplayOptions();
        }
    }
}
