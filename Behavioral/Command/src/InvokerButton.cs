namespace Command
{
    public class InvokerButton
    {
        private readonly ICommand Command;

        public InvokerButton(ICommand command)
        {
            this.Command = command;
        }

        public void Click()
        {
            this.Command.Execute();
        }
    }
}
