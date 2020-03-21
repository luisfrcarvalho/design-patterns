using System;
namespace Command
{
    public class UndoCommand : ICommand
    {
        private History CommandsHistory;

        public UndoCommand(History history)
        {
            this.CommandsHistory = history;
        }

        public void Execute()
        {
            if (CommandsHistory.UndoableCommands.Count > 0)
            {
                CommandsHistory.UndoableCommands.Dequeue().Execute();
            }
        }
    }
}
