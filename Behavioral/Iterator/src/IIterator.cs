namespace Iterator
{
    public interface IIterator<T>
        where T : class
    {
        bool HasNext();

        T Current();

        void Next();
    }
}
