using System;
namespace Strategy
{
    public class Strategy : IStrategy
    {
        public Strategy()
        {
        }

        public string Apply()
        {
            return "Strategy Applied!";
        }
    }
}
