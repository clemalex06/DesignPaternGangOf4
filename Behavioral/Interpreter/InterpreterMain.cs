using System;

namespace Interpreter
{
    /*
     * Interpreter's Concept :
     * Given a language, define a representation for its grammar along with an interpreter 
     * that uses the representation to interpret sentences in the language.
     * Map a domain to a language, the language to a grammar, and the grammar to a hierarchical object-oriented design.
     */
    public static class InterpreterMain
    {
        public static void Main()
        {
            Console.WriteLine("Write your request");
            string request = Console.ReadLine();

            Expression expression;
            try
            {
                expression = Expression.Analyse(request);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                expression = null;
            }

            if (expression != null)
            {
                Console.WriteLine("Write the texte to describe a car");
                string description = Console.ReadLine();
                if (expression.Evaluate(description))
                    Console.WriteLine("The description ANSWERS to the request");
                else
                    Console.WriteLine("The description DOESN'T ANSWERS to the request");
            }
        }
    }
}
