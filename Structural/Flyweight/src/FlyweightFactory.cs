using System.Collections.Generic;

namespace Flyweight
{
    // We relly on this factory to make sure that we don't end up creating the same flyweight multiples times in memory.
    public class FlyweightFactory
    {
        private Dictionary<FlyweightType, Flyweight> Flyweights = new Dictionary<FlyweightType, Flyweight>();

        public Flyweight GetFlyweight(FlyweightType type) 
        {
            if (!Flyweights.ContainsKey(type))
                Flyweights.Add(type, new Flyweight(type, null));

            return Flyweights[type];
        }
    }
}
