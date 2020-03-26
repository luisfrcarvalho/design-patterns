namespace ChainOfResponsability
{
    public class WebServer
    {
        public Handler RequestHandler;

        public WebServer(Handler handler)
        {
            this.RequestHandler = handler;
        }

        public void HandleRequest(Request request)
        {
            this.RequestHandler.handle(request);
        }
    }
}
