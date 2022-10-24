using System;
namespace Bridge
{
    public class ReactForm : IFormImplementation
    {
        public void WriteText(string text)
        {
            Console.WriteLine($"React : {text}");
        }

        public string ManageInputArea()
        {
            return Console.ReadLine();
        }
    }
}
