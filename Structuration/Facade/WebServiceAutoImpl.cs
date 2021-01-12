using System;
using System.Collections.Generic;

namespace Facade
{
    public class WebServiceAutoImpl:WebServiceAuto
    {
        protected Catalogue catalogue = new ComposantCatalogue();
        protected GestionDocument gestionDocument = new ComposantGestionDocument();

        public IList<string> chercheVehicules(int prixMoyen, int ecartMax)
        {
            return catalogue.
                retrouveVehicule(prixMoyen - ecartMax, prixMoyen + ecartMax);
        }

        public string document(int index)
        {
            return gestionDocument.document(index);
        }
    }
}
