namespace Strategy
{
    /*
     * ### Strategy's Concept :
     * Lets you define a family of algorithms, 
     * put each of them into a separate class, and make their objects interchangeable.
     */
    public static class StrategyMain
    {
        public static void Main()
        {
            var catalogView1 = new CatalogView(new DrawThreeCarsPerLine());
            catalogView1.Draw();
            var catalogView2 = new CatalogView(new DrawOneCarPerLine());
            catalogView2.Draw();
        }
    }
}
