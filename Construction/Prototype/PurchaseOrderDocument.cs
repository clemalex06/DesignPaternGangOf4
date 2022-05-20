using System;
namespace Prototype
{
    public class PurchaseOrderDocument : Document
    {

        public override void Display()
        {
            Console.WriteLine($"Display the Purchase Order : {Content}");
        }

        public override void Print()
        {
            Console.WriteLine($"Print the Purchase Order : {Content}");
        }
    }
}
