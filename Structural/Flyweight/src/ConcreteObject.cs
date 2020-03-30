using System;

namespace Flyweight
{
    public class ConcreteObject
    {
        public int Id;

        public Flyweight Shared;

        public ConcreteObject(int id, Flyweight flyweight)
        {
            this.Id = id;
            this.Shared = flyweight;
        }

        public void Execute() 
        {
            Console.WriteLine($"{this.Id} - Type: {this.Shared.Type}");
        }
    }
}
