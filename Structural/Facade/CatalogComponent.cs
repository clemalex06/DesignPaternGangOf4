using System.Collections.Generic;
namespace Facade
{
    public class CatalogComponent : ICatalog
    {
        protected object[] carDescriptions =
        {
            "Sedan with 5 doors", 6000, "Compact with 3 doors", 4000
             ,"Space with 5 doors", 8000, "Break with 5 doors", 7000,
            "Coupe with 2 doors", 9000, "Utility with 3 doors", 5000
        };

        public IList<string> SearchCars(int minPrice, int maxPrice)
        {
            int index, length;
            var result = new List<string>();
            length = carDescriptions.Length / 2;
            for (index = 0; index < length; index++)
            {
                int price = (int)carDescriptions[2 * index + 1];

                if (price >= minPrice && price <= maxPrice)
                {
                    result.Add((string)carDescriptions[2 * index]);
                }
            }
            return result;
        }
    }
}