using System;
namespace Mediator
{
    public class TextArea : Control
    {
        public TextArea(string name) : base(name)
        {
        }

        public override void Input()
        {
            Console.WriteLine($"Input of : {Name}");
            Value = Console.ReadLine();
            Modify();
        }
    }
}
