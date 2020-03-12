using System.Collections.Generic;

namespace Iterator
{
    public partial class IterableCollection
    {
        private List<string> Collection { get; set; }

        public IterableCollection()
        {
            Collection = new List<string>();
        }

        public void Push(string value)
        {
            Collection.Add(value);
        }

        public string Pop()
        {
            var LastIndex = Collection.Count - 1;
            var valueAtLastIndex = Collection[LastIndex];
            Collection.Remove(valueAtLastIndex);

            return valueAtLastIndex;
        }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }
    }
}
