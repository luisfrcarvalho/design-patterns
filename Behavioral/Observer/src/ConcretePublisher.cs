namespace Observer
{
    public class ConcretePublisher : Publisher
    {
        private string Value;

        public ConcretePublisher(string value) : base()
        {
            this.Value = value;
        }

        public void ChangeValue(string value)
        {
            this.Value = value;
            this.Notify();
        }
    }
}
