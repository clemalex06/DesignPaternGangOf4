using System;

namespace Interpreter
{
    /*
     * * Concept de l'interpreter
     * * fournit un cadre pour donner une représentation par objets de la
     * * grammaire d'un langage afin d'évaluer, en les intérprétant,
     * * des expressions écrites dans ce langage
     * 
     */
    public class Utilisateur
    {
        public static void Main(string[] args)
        {
            Expression expressionRequete = null;
            Console.WriteLine("Entrez votre requete");
            string requete = Console.ReadLine();

            try
            {
                expressionRequete = Expression.analyse(requete);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                expressionRequete = null;
            }

            if (requete != null)
            {
                Console.WriteLine(
                    "Entrez le texte de description d'un vehicule");
                string description = Console.ReadLine();
                if (expressionRequete.evalue(description))
                    Console.WriteLine(" la description repond a la requete");
                else
                    Console.WriteLine("La desription ne " +
                        "repond pas a la requete");
            }
        }
    }
}
