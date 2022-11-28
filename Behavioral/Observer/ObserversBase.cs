using System.Collections.Generic;
namespace Observer
{
    public abstract class ObserversBase
    {
        protected IList<IObserver> Observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
                observer.Refresh();
        }
    }
}
