using System;
using System.Collections.Generic;
namespace Memento
{
    public class ItemsCart
    {
        protected IList<Item> Items =
            new List<Item>();

        public IMemento AddItem(Item item)
        {
            var result = new Memento();
            result.State = Items;
            var incompatiblesItems = item.IncompatiblesItems;
            foreach (var incompatibleItem in incompatiblesItems)
            {
                Items.Remove(incompatibleItem);
            }
            Items.Add(item);
            return result;
        }

        public void Cancel(IMemento memento)
        {
            var instance = memento as Memento;
            if (instance == null)
                return;
            Items = instance.State;
        }

        public void Display()
        {
            Console.WriteLine("Items Cart Content : ");
            foreach (var item in Items)
                item.Display();
            Console.WriteLine();
        }
    }
}
