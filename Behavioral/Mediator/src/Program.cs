using System;

namespace Mediator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ConcreteMediator concreteMediator = new ConcreteMediator();
            concreteMediator.Simulation();
        }
    }
}
