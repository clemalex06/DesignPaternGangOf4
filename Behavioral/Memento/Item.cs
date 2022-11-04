using System;
using System.Collections.Generic;
namespace Memento
{
    public class Item
    {
        protected string Name;
        public IList<Item> IncompatiblesItems { get; protected set; }

        public Item(string nom)
        {
            IncompatiblesItems = new List<Item>();
            Name = nom;
        }

        public void AddIncompatibleItem(
            Item IncompatibleItem)
        {
            if (!IncompatiblesItems.Contains(IncompatibleItem))
            {
                IncompatiblesItems.Add(IncompatibleItem);
                IncompatibleItem.AddIncompatibleItem(this);
            }
        }

        public void Display()
        {
            Console.WriteLine($"Item : {Name}");
        }
    }
}
