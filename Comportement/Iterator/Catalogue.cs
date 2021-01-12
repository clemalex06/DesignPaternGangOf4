using System.Collections.Generic;
namespace Iterator
{
    public abstract class Catalogue<TELement,TIterateur>
        where TELement:Element
        where TIterateur: Iterateur<TELement>,new()
    {
        protected IList<TELement> contenu = new List<TELement>();

        public TIterateur recherche(string motCleRequete)
        {
            TIterateur resultat = new TIterateur();
            resultat.motCleRequete = motCleRequete;
            resultat.contenu = contenu;
            return resultat;
        }
    }
}
