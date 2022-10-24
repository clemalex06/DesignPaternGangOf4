using System.Collections.Generic;
namespace Facade
{
    public interface ICatalog
    {
        IList<string> SearchCars(int minPrice, int maxPrice);
    }
}
