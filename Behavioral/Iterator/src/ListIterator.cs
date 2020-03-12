namespace Iterator
{
    public partial class IterableCollection
    {
        public class ListIterator : IIterator<string>
        {
            private readonly IterableCollection IterableCollection;
            private int Index;

            public ListIterator(IterableCollection iterableCollection)
            {
                this.IterableCollection = iterableCollection;
            }

            public string Current()
            {
                return IterableCollection.Collection[Index];
            }

            public bool HasNext()
            {
                return (Index < IterableCollection.Collection.Count);
            }

            public void Next()
            {
                Index++;
            }
        }
    }
}
