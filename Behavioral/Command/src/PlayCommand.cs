namespace Command
{
    public class PlayCommand : ICommand
    {
        private readonly Receiver Receiver;

        public PlayCommand(Receiver receiver)
        {
            this.Receiver = receiver;
        }

        public void Execute()
        {
            this.Receiver.Play();
        }
    }
}
