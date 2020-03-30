using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAbstraction concreteAbstraction = new ConcreteAbstraction(new ConcreteImplementation());
            concreteAbstraction.Execute();
        }
    }
}
