using System;

namespace Composite
{
    class Component : IComponent
    {
        public void Execute()
        {
            Console.WriteLine("Executing " + nameof(Component));
        }
    }
}
