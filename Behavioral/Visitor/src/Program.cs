using System;

namespace Visitor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ConcreteVisitor visitor = new ConcreteVisitor();
            ConcreteElement1 concreteElement1 = new ConcreteElement1();
            concreteElement1.accept(visitor);
            ConcreteElement2 concreteElement2 = new ConcreteElement2();
            concreteElement2.accept(visitor);
        }
    }
}
