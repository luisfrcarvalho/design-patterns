namespace Command
{
    public class UndoableCommand : IUndoableCommand
    {
        public string PreviousContent;
        public Receiver Receiver;
        public History UndoableCommandsHistory;


        public UndoableCommand(Receiver receiver, History history)
        {
            Receiver = receiver;
            UndoableCommandsHistory = history;
        }

        public void Execute()
        {
            PreviousContent = Receiver.Content;
            Receiver.MakeBold();
            UndoableCommandsHistory.UndoableCommands.Enqueue(this);
        }

        public void Unexecute()
        {
            Receiver.Content = PreviousContent;
        }
    }
}
