using System;

namespace Memento
{
    /*
     * ### Memento's Concept :
     * Lets you save and restore the previous state of an object 
     * without revealing the details of its implementation.
     */
    public static class MementoMain
    {
        public static void Main()
        {
            IMemento memento;
            var item1 = new Item("kitchen knife");
            var item2 = new Item("Fork");
            var item3 = new Item("Swiss knife");

            item1.AddIncompatibleItem(item3);
            item2.AddIncompatibleItem(item3);

            var itemsCart = new ItemsCart();
            itemsCart.AddItem(item1);
            itemsCart.AddItem(item2);
            itemsCart.Display();
            memento = itemsCart.AddItem(item3);
            itemsCart.Display();
            itemsCart.Cancel(memento);
            itemsCart.Display();
        }
    }
}
