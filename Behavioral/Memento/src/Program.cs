using System;

namespace MementoPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            History history = new History();
            Editor editor = new Editor();

            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Content = "b";
            history.Push(editor.CreateState());

            editor.Content = "c";

            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);

            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);
        }
    }
}
