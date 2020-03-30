namespace Bridge
{
    public abstract class Abstraction
    {
        protected IImplementation TheBridge;

        protected Abstraction(IImplementation bridge)
        {
            this.TheBridge = bridge;
        }

        public abstract void Execute();
    }
}
