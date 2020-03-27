using System;

namespace Adapter
{
    public class ThirdPartyLibrary
    {
        public void Render() 
        {
            Console.WriteLine("Rendering " + nameof(ThirdPartyLibrary));
        }
    }
}
