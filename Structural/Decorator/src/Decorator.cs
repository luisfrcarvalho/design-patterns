using System;

namespace Decorator
{
    public class Decorator : IComponent
    {
        private IComponent Component;

        public Decorator(IComponent component)
        {
            this.Component = component;
        }

        public void Operation()
        {
            // Additional behavior added by the decorator
            Console.WriteLine("Operation on " + nameof(Decorator));
            // Delegating the operation to other component
            this.Component.Operation();
        }
    }
}
