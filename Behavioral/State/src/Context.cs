using System;

namespace StatePattern
{
    public class Context
    {
        public State State { get; set; }

        public Context()
        {
        }

        public void draw()
        {
            Console.Write(State.draw());
        }
    }
}
