using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component1 = new Component();
            Component component2 = new Component();
            Component component3 = new Component();
            Composite composite = new Composite();
            Composite composite2 = new Composite();
            composite2.AddComponent(component1);
            composite2.AddComponent(component2);
            composite2.AddComponent(component3);
            composite.AddComponent(composite2);
            composite.Execute();
        }
    }
}
