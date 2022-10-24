using System;
namespace TemplateMethod
{
    public class CommandeFrance : Commande
    {
        protected override void calculeTva()
        {
            montantTva = montantHt * 0.196;
        }
    }
}
