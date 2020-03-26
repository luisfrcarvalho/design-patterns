using System;
namespace Mediator
{
    public class ConcreteMediator : Mediator
    {
        private Component1 Component1;

        private Component1 Component2;

        public ConcreteMediator()
        {
            this.Component1 = new Component1(this);
            this.Component2 = new Component1(this);
        }

        public void Simulation()
        {
            Component1.SetContent("Simulation");
        }

        public override void Changed(Component component)
        {
            if (component == Component1)
            {
                HandlingComponent1();
            }
            else if (component == Component2)
            {
                HandlingComponent1();
            }
        }

        private void HandlingComponent1()
        {
            Console.WriteLine(nameof(HandlingComponent1) + "Content: " + Component1.Content);

        }
    }
}
