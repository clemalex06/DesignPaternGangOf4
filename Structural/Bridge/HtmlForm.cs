using System;
namespace Bridge
{
    public class HtmlForm : IFormImplementation
    {
        public void WriteText(string text)
        {
            Console.WriteLine($"HTML : {text}");
        }

        public string ManageInputArea()
        {
            return Console.ReadLine();
        }
    }
}
