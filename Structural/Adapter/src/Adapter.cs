namespace Adapter
{
    public class Adapter : IFilter
    {
        private ThirdPartyLibrary ThirdPartyLibrary;

        public Adapter(ThirdPartyLibrary thirdParty) 
        {
            this.ThirdPartyLibrary = thirdParty;
        }

        public void Apply()
        {
            this.ThirdPartyLibrary.Render();
        }
    }
}
