using System.Collections.Generic;
using System;
namespace Mediator
{
    public class PopupMenu : Control
    {
        protected IList<string> options = new List<string>();

        public PopupMenu(string name) : base(name)
        {
        }

        public override void Input()
        {
            Console.WriteLine($"Input {Name} :");
            Console.WriteLine($"Actual Value : {Value}");
            for (int index = 0; index < options.Count; index++)
                Console.WriteLine($"- {index} ) {options[index]}");
            if (int.TryParse(Console.ReadLine(), out int choice) && (choice >= 0) && (choice < options.Count))
            {
                bool hasChanged = (Value != options[choice]);
                if (hasChanged)
                {
                    Value = options[choice];
                    Modify();
                }
            }
        }

        public void AddOption(string option)
        {
            options.Add(option);
        }
    }
}
