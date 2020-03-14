using System;
namespace Template
{
    public class ConcreteClass1 : AbstractClass
    {
        public ConcreteClass1()
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine(nameof(ConcreteClass1));
        }
    }
}
