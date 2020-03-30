using System;

namespace Proxy
{
    public class RealSubject : ISubject
    {
        public string Data;

        public RealSubject(string data)
        {
            this.Data = data;
        }

        public void Request()
        {
            Console.WriteLine("Loading " + this.Data);
        }
    }
}
