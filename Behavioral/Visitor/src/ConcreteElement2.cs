using System;
namespace Visitor
{
    public class ConcreteElement2 : IElement
    {
        public ConcreteElement2()
        {
        }

        public void accept(IVisitor visitor)
        {
            visitor.apply(this);
        }
    }
}
