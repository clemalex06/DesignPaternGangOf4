using System;

namespace TemplateMethod
{
    /*
     *
     * Concept du template Method
     * Permet de reporter dans des sous-classes certaines étapes de l'une
     * des opérations d'un objet, ces étapes étant alors décrites dans
     * les sous classes
     * 
     */
    public class Utilisateur
    {
        public static void Main(string[] args)
        {
            var commandeFrance = new CommandeFrance();
            commandeFrance.setMontantHt(10000);
            commandeFrance.calculeMontantTtc();
            commandeFrance.affiche();

            var commandeLuxembourg = new CommandeLuxembourg();
            commandeLuxembourg.setMontantHt(10000);
            commandeLuxembourg.calculeMontantTtc();
            commandeLuxembourg.affiche();
        }
    }
}
