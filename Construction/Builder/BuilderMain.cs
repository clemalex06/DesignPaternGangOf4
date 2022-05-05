using System;

namespace Builder
{
    /*
     *
     * Builder's Concept :
     * Allows the construction of complex objects to be separated from their layout, so that a client can create these complex objects with different layouts.
     * 
     */

    public static class BuilderMain
    {
        public static void Main()
        {
            BundleForVehicule bundleForVehicule;
            Console.WriteLine(" Hello Sale Man : do you want to use 'HTML' bundle for vhehicules(1) or 'PDF' bundle for vhehicules(Default) ??");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                bundleForVehicule = new HtmlBundleForVehicule();
            }
            else
            {
                bundleForVehicule = new PdfBundleForVehicule();
            }

            var salesMan = new SalesMan(bundleForVehicule);
            Bundle bundle = salesMan.Build("Martin");
            bundle.Print();
        }
    }
}
