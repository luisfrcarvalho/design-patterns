namespace Facade
{
    public class Facade
    {
        public ThirdPartyLibrary ThirdPartyLibrary;

        public Facade(ThirdPartyLibrary thirdPartyLibrary)
        {
            this.ThirdPartyLibrary = thirdPartyLibrary;
        }

        public void Connect()
        {
            var token = OAuthToken.GetToken();
            var connection = Connection.GetConnection();
            this.ThirdPartyLibrary.Connect(token, connection);
        }
    }
}
