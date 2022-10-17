namespace Singleton
{
    /*
     * Singleton's Concept :
     * restricts the instantiation of a class to one "single" instance.
     * 
     */
    public static class SingletonMain
    {
        public static void Main()
        {
            SalesMan carSalesMan = SalesMan.Instance();
            carSalesMan.Adress = "1 clock street";
            carSalesMan.Name = "Car Sales Man";
            carSalesMan.Email = "email@emao.fr";
            Display();
        }

        public static void Display()
        {
            SalesMan thesalesman = SalesMan.Instance();
            thesalesman.Display();
        }
    }
}
