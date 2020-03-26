namespace ChainOfResponsability
{
    public abstract class Handler
    {
        protected Handler Next;

        public Handler(Handler handler)
        {
            this.Next = handler;
        }

        public void handle(Request request)
        {
            if (doHandle(request) && this.Next != null)
                this.Next.handle(request);
        }

        protected abstract bool doHandle(Request request);
    }
}
