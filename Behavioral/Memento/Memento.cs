using System.Collections.Generic;
namespace Memento
{
    public class Memento:IMemento
    {
        public IList<Item> Items = new List<Item>();

        public IList<Item> State
        {
            get
            {
                return Items;
            }
            set
            {
                Items.Clear();
                foreach (var item in value)
                    Items.Add(item);
            }
        }
        public Memento()
        {
        }
    }
}
