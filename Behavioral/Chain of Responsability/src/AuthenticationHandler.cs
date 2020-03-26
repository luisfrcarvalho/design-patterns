using System;
namespace ChainOfResponsability
{
    public class AuthenticationHandler : Handler
    {
        public AuthenticationHandler(Handler next) : base(next)
        {
        }

        protected override bool doHandle(Request request)
        {
            Console.WriteLine(nameof(AuthenticationHandler));
            return true;
        }
    }
}
