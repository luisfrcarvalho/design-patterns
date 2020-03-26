namespace Mediator
{
    // Although we are using an abstract class, we're not taking any benefit from it. As a result, we could have used an interface.
    // In case we need to add common behavior to different Mediators, it made me follow this approach.
    public abstract class Mediator
    {
        public Mediator()
        {
        }

        public abstract void Changed(Component component);
    }
}
