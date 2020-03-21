using System.Collections.Generic;

namespace Observer
{
    // Observable
    public abstract class Publisher
    {
        protected List<IObserver> Observers;

        public Publisher()
        {
            this.Observers = new List<IObserver>();
        }

        public void AttachObserver(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void DetachObserver(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var observer in this.Observers)
            {
                observer.Update();
            }
        }
    }
}
