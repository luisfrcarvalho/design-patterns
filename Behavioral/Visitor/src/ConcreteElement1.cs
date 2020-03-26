using System;
namespace Visitor
{
    public class ConcreteElement1 : IElement
    {
        public ConcreteElement1()
        {
        }

        public void accept(IVisitor visitor)
        {
            visitor.apply(this);
        }
    }
}
