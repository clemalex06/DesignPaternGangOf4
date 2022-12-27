using System;
namespace Adapter
{
    /*
     * Adapter's Concept :
     * Allows objects with incompatible interfaces to collaborate.
     */

    public static class AdapterMain
    {
        public static void Main()
        {
            Document document1, document2;
            document1 = new Documenthtml();
            document1.Content = "Hello Html";
            document1.Draw();
            Console.WriteLine();
            document2 = new DocumentPdf();
            document2.Content = "Hello Pdf";
            document2.Draw();
        }
    }
}
