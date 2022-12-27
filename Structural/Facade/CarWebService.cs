using System.Collections.Generic;
namespace Facade
{
    public class CarWebService : ICarWebService
    {
        protected ICatalog catalog = new CatalogComponent();
        protected IDocumentManagement documentManagement = new DocumentManagementComponent();

        public IList<string> SearchCars(int averagePrice, int maxDeviation)
        {
            return catalog.
                SearchCars(averagePrice - maxDeviation, averagePrice + maxDeviation);
        }

        public string Document(int index)
        {
            return documentManagement.Document(index);
        }
    }
}
