namespace Adapter
{
    public class DocumentPdf : Document
    {

        protected ComponentPdf ComponentPdf = new ComponentPdf();

        public string Content
        {
            set
            {
                ComponentPdf.PdfSetContent(value);
            }
        }

        public void Draw()
        {
            ComponentPdf.StartDisplay();
            ComponentPdf.Refresh();
            ComponentPdf.EndDisplay();
        }

        public void Print()
        {
            ComponentPdf.SendToPrinter();
        }
    }
}
