using System;
namespace Multicast
{
    public class Commercial : Employe, RecepteurCommercial
    {
        public Commercial(string nom)
            :base(nom)
        {
        }

        public void recoit(MessageCommercial message)
        {
            Console.WriteLine("Message commercial");
            Console.WriteLine($"Nom : {nom}");
            Console.WriteLine($"Message : {message.contenu}");
        }
    }
}
