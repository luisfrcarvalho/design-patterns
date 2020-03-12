using System;
namespace Strategy
{
    public class Strategy2 : IStrategy
    {
        public Strategy2() 
        {
        }

        public string Apply()
        {
            return "Strategy 2 Applied!";
        }
    }
}
