using System;

namespace Iterator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IterableCollection iterableCollection = new IterableCollection();
            iterableCollection.Push("a");
            iterableCollection.Push("b");
            iterableCollection.Push("c");

            IIterator<string> iterator = iterableCollection.CreateIterator();

            while (iterator.HasNext())
            {
                var value = iterator.Current();
                Console.WriteLine(value);
                iterator.Next();
            }
        }
    }
}
