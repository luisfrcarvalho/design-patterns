namespace Mediator
{
    public class Component
    {
        protected readonly Mediator Mediator;

        public Component(Mediator mediator)
        {
            this.Mediator = mediator;
        }
    }
}
