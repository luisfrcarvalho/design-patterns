using System;

namespace Observer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            ConcretePublisher concretePublisher = new ConcretePublisher("teste");
            concretePublisher.AttachObserver(observer1);
            concretePublisher.AttachObserver(observer2);
            concretePublisher.ChangeValue("test2");
        }
    }
}
