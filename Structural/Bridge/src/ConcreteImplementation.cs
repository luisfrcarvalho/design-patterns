using System;

namespace Bridge
{
    public class ConcreteImplementation : IImplementation
    {
        public void Execute()
        {
            Console.WriteLine($"Executing: {nameof(ConcreteImplementation)}");
        }
    }
}
