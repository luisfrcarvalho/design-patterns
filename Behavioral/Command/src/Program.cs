using System;

namespace Command
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("- Command -");
            var receiverService = new Receiver();
            var playCommand = new PlayCommand(receiverService);
            InvokerButton invokerButton = new InvokerButton(playCommand);
            invokerButton.Click();
            Console.WriteLine("\n- Composite Command -");
            CompositeCommand compositeCommand = new CompositeCommand();
            compositeCommand.AddCommand(playCommand);
            compositeCommand.AddCommand(playCommand);
            compositeCommand.AddCommand(playCommand);
            InvokerButton invokerButton1 = new InvokerButton(compositeCommand);
            invokerButton1.Click();
            Console.WriteLine("\n- Undo Operation -");
            History _history = new History();
            var receiverService1 = new Receiver();
            UndoableCommand undoableCommand = new UndoableCommand(receiverService1, _history);
            undoableCommand.Execute();
            Console.WriteLine(receiverService1.Content);
            //undoableCommand.Unexecute();
            //Console.WriteLine(receiverService1.Content);
            UndoCommand undoCommand = new UndoCommand(_history);
            undoCommand.Execute();
            Console.WriteLine(receiverService1.Content);
        }
    }
}
