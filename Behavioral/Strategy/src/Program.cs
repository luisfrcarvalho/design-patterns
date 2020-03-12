using System;

namespace Strategy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Context context = new Context(new Strategy());
            Console.WriteLine(context.Run());
            Context context1 = new Context(new Strategy2());
            Console.WriteLine(context1.Run());
        }
    }
}
