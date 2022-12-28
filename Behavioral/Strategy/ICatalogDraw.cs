using System.Collections.Generic;
namespace Strategy
{
    public interface ICatalogDraw
    {
        void Draw(IList<CarView> contenu);
    }
}
