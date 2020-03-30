namespace Bridge
{
    class ConcreteAbstraction : Abstraction
    {
        public ConcreteAbstraction(IImplementation bridge) : base(bridge) 
        { 
        }

        public override void Execute()
        {
            this.TheBridge.Execute();
        }
    }
}
