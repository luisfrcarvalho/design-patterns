namespace Strategy
{
    public class Context
    {
       private IStrategy Strategy;

        public Context(IStrategy strategy)
        {
            this.Strategy = strategy;
        }


        public string Run()
        {
            return Strategy.Apply();
        }
    }
}
