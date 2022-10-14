using System;

namespace Bridge
{
    /*
     * Bridge's Concept :
     * Lets you split a large class or a set of closely related classes
     * into two separate hierarchies—abstraction and implementation—which 
     * can be developed independently of each other.
     */

    public static class BridgeMain
    {
        public static void Main()
        {
            InsuranceNumberFormSpain spainForm =
                new InsuranceNumberFormSpain(
                    new HtmlForm());
            spainForm.Display();
            if (spainForm.ManageInput())
                spainForm.GenerateNumber();
            Console.WriteLine();

            InsuranceNumberFormFrance frenchForm =
                new InsuranceNumberFormFrance(
                    new ReactForm());
            frenchForm.Display();
            if (frenchForm.ManageInput())
                frenchForm.GenerateNumber();
        }
    }
}
