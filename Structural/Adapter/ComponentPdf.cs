using System;
namespace Adapter
{
    public class ComponentPdf
    {
        protected string Content;

        public void PdfSetContent(string contenu)
        {
            this.Content = contenu;
        }

        public void StartDisplay()
        {
            Console.WriteLine("Start Display PDF");
        }

        public void Refresh()
        {
            Console.WriteLine($"Refresh PDF Content : {Content}");
        }

        public void EndDisplay()
        {
            Console.WriteLine("End Display PDF");
        }

        public void SendToPrinter()
        {
            Console.WriteLine($"Print PDF : {Content}");
        }
    }
}
