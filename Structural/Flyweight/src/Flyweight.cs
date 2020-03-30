namespace Flyweight
{
    public class Flyweight
    {
        // Readonly guarantees that once we initialize the fields using the constructor we cannot change them later on.
        public readonly FlyweightType Type;
        public readonly byte[] Data;

        public Flyweight(FlyweightType type, byte[] data) 
        {
            this.Type = type;
            this.Data = data;
        }
    }

    public enum FlyweightType
    {
        Type1,
        Type2
    }
}
