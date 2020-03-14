using System;

namespace Template
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AbstractClass concrete1 = new ConcreteClass1();
            concrete1.TemplateMethod();
            AbstractClass concrete2 = new ConcreteClass2();
            concrete2.TemplateMethod();
        }
    }
}
