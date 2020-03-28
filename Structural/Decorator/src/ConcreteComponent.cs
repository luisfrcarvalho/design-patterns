using System;

namespace Decorator
{
    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Operation on " + nameof(ConcreteComponent));
        }
    }
}
