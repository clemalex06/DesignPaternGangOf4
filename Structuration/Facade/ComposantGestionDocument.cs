using System;
namespace Facade
{
    public class ComposantGestionDocument:GestionDocument
    {

        public string document(int index)
        {
            return $"Document numero {index}";
        }
    }
}
