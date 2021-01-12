using System.Collections.Generic;
namespace Facade
{
    public interface Catalogue
    {
        IList<string> retrouveVehicule(int prixMin, int prixMax);
    }
}
