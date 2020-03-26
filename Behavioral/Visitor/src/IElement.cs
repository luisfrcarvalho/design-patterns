namespace Visitor
{
    public interface IElement
    {
        void accept(IVisitor visitor);
    }
}
