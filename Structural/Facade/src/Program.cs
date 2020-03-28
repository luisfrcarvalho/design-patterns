namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade(new ThirdPartyLibrary());
            facade.Connect();
        }
    }
}
