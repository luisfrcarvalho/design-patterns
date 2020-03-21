using System.Collections.Generic;
namespace Command
{
    /*
     * We can store user actions and execute them later
     */
    public class CompositeCommand : ICommand
    {
        private List<ICommand> Commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            this.Commands.Add(command);
        }

        public void Execute()
        {
            foreach(var command in Commands)
            {
                command.Execute();
            }
        }
    }
}
