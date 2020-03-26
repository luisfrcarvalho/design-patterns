using System;

namespace ChainOfResponsability
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AuthenticationHandler authenticationHandler = new AuthenticationHandler(new LoggingHandler(null));
            WebServer webServer = new WebServer(authenticationHandler);
            webServer.HandleRequest(new Request());
        }
    }
}
