using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Decorator decorator = new Decorator(new ConcreteComponent());
            decorator.Operation();
        }
    }
}
