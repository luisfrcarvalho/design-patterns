using System;
namespace ChainOfResponsability
{
    public class LoggingHandler : Handler
    {
        public LoggingHandler(Handler next): base(next)
        {
        }

        protected override bool doHandle(Request request)
        {
            Console.WriteLine(nameof(LoggingHandler));
            return true;
        }
    }
}
