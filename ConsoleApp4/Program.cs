using ConsoleApp4.Proxies;

class Program
{
    static void Main()
    {
        var proxySite = new ProxySite("example.com");

        proxySite.Request("User1");
        proxySite.Request("User2");
        proxySite.Request("User1");
        proxySite.Request("User3");
    }
}