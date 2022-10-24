using System.Collections.Generic;
namespace Facade
{
    public interface ICarWebService
    {
        string Document(int index);
        IList<string> SearchCars(int averagePrice, int maxDeviation);

    }
}
