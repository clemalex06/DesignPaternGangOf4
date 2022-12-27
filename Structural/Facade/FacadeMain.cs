using System;
namespace Facade
{
    /*
     * Facade's Concept :
     * Provides a simplified interface to a library, 
     * a framework, or any other complex set of classes.
     */
    public static class FacadeMain
    {
        public static void Main()
        {
            var carWebService = new CarWebService();

            Console.WriteLine(carWebService.Document(0));
            Console.WriteLine(carWebService.Document(1));
            var results = carWebService.SearchCars(
                6000, 1000);
            if (results.Count > 0)
            {
                Console.WriteLine("Cars where price is between 5000 and 7000 euros");
                foreach (var result in results)
                    Console.WriteLine(result);
            }
        }
    }
}
