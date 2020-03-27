using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : IComponent
    {
        private List<IComponent> Components;
        
        public Composite() 
        {
            this.Components = new List<IComponent>();
        }

        public void Execute()
        {
            Console.WriteLine("Executing " + nameof(Composite));
            foreach(var component in this.Components)
            {
                component.Execute();
            }
        }

        public void AddComponent(IComponent component)
        {
            this.Components.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            this.Components.Remove(component);
        }
    }
}
