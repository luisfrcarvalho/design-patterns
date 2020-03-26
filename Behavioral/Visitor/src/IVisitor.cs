namespace Visitor
{
    public interface IVisitor
    {
        void apply(ConcreteElement1 concreteElement1);

        void apply(ConcreteElement2 concreteElement2);
    }
}