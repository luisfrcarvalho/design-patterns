using System;

namespace Visitor
{
    public class ConcreteVisitor : IVisitor
    {
        public ConcreteVisitor()
        {
        }

        public void apply(ConcreteElement1 concreteElement1)
        {
            Console.WriteLine("Applying on " + nameof(concreteElement1));
        }

        public void apply(ConcreteElement2 concreteElement2)
        {
            Console.WriteLine("Applying on " + nameof(concreteElement2));
        }
    }
}
