using System;

namespace Proxy
{
    public class Proxy : ISubject
    {
        public RealSubject RealSubject;

        public string Data;

        public Proxy(string data)
        {
            this.Data = data;
        }

        public void Request()
        {
            if (RealSubject == null)
                RealSubject = new RealSubject(this.Data); // Here you could get the data from the database, for example.
             
            RealSubject.Request();
        }
    }
}
