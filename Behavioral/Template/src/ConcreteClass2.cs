using System;
namespace Template
{
    public class ConcreteClass2 : AbstractClass
    {
        public ConcreteClass2()
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine(nameof(ConcreteClass2));
        }
    }
}
