using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory flyweightFactory = new FlyweightFactory();
            ConcreteObject concreteObject1 = new ConcreteObject(1, flyweightFactory.GetFlyweight(FlyweightType.Type1));
            ConcreteObject concreteObject2 = new ConcreteObject(1, flyweightFactory.GetFlyweight(FlyweightType.Type1));
            ConcreteObject concreteObject3 = new ConcreteObject(1, flyweightFactory.GetFlyweight(FlyweightType.Type1));
            // Same reference in memory
            Console.Write((concreteObject1.Shared == concreteObject2.Shared) && (concreteObject2.Shared == concreteObject3.Shared));
        }
    }
}
