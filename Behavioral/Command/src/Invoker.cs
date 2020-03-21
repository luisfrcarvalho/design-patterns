namespace Command
{
    public class Invoker
    {
        private readonly ICommand Command;

        public Invoker(ICommand command)
        {
            this.Command = command;
        }

        public void ExcuteCommand()
        {
            Command.Execute();
        }
    }
}
