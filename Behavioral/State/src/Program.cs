using System;

namespace StatePattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Context context = new Context();
            context.State = new ConcreteState1();
            context.draw();
            context.State = new ConcreteState2();
            context.draw();
        }
    }
}
