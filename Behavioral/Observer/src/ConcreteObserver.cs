using System;
namespace Observer
{
    public class ConcreteObserver : IObserver
    {
        public ConcreteObserver()
        {
        }

        public void Update()
        {
            Console.WriteLine($"{nameof(ConcreteObserver)} - Receiving an update from Publisher");
        }
    }
}
