using System.Collections.Generic;

namespace Command
{
    public class History
    {
        public Queue<IUndoableCommand> UndoableCommands = new Queue<IUndoableCommand>();
    }
}
