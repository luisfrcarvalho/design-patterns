namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using a ThirdPartyLibrary trough IFilter interface
            Adapter adapter = new Adapter(new ThirdPartyLibrary());
            adapter.Apply();
        }
    }
}
