using System;
using System.Collections.Generic;

namespace Facade
{
    /*
     *
     *Concept de la Facade
     * a pour but de regrouper les interfaces d'un ensemble
     * d'objets en une interface unifiée rendant cet ensemble plus simple
     * à utiliser
     * 
     */
    public class UtilisateurWebService
    {
        public static void Main(string[] args)
        {
            var webServiceAuto = new WebServiceAutoImpl();

            Console.WriteLine(webServiceAuto.document(0));
            Console.WriteLine(webServiceAuto.document(1));
            var resultats = webServiceAuto.chercheVehicules(
                6000, 1000);
            if (resultats.Count > 0)
            {
                Console.WriteLine("Vehicules dont le prix est compris" +
                    "entre 5000 et 7000");
                foreach (var result in resultats)
                    Console.WriteLine(result);
            }
        }
    }
}
