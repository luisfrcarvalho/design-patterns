namespace Mediator
{
    public class Component1 : Component
    {
        public string Content { get; private set; }

        public Component1(Mediator mediator) : base(mediator)
        {
            
        }

        public void SetContent(string content)
        {
            this.Content = content;
            this.Mediator.Changed(this);
        }

    }
}
