using System;

namespace Facade
{
    public class ThirdPartyLibrary
    {
        public void Connect(string Token, string Connection)
        {
            Console.WriteLine(nameof(Connect));
        }
    }

    public class OAuthToken
    {
        public static string GetToken() 
        {
            Console.WriteLine(nameof(GetToken));
            return string.Empty;
        }
    }

    public class Connection
    {
        public static string GetConnection()
        {
            Console.WriteLine(nameof(GetConnection));
            return string.Empty;
        }
    }
}
