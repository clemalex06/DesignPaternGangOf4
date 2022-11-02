using System;
namespace Mediator
{
    public class Button : Control
    {
        public Button(string name) : base(name)
        {
        }

        public override void Input()
        {
            Console.WriteLine($"Do you want to activate the button " +
                $"{Name} ?? ('y' or 'n')");
            string reponse = Console.ReadLine();
            if (reponse == "y")
                Modify();
        }
    }
}
