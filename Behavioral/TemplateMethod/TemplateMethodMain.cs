namespace TemplateMethod
{
    /*
     * ### TemplateMethod's Concept :
     * Defines the skeleton of an algorithm in the superclass
     * but lets subclasses override specific steps of the algorithm without changing its structure.
     */
    public static class TemplateMethodMain
    {
        public static void Main()
        {
            var initialPrice = 10000;
            var commandeFrance = new FrenchPrice();
            commandeFrance.SetInitialPrice(initialPrice);
            commandeFrance.ComputePriceWithTax();
            commandeFrance.Display();

            var commandeLuxembourg = new SpanishPrice();
            commandeLuxembourg.SetInitialPrice(initialPrice);
            commandeLuxembourg.ComputePriceWithTax();
            commandeLuxembourg.Display();
        }
    }
}
