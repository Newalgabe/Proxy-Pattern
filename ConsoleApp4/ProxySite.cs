using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ConsoleApp4.Proxies
{
    public class ProxySite : Subjects.ISite
    {
        private RealSubjects.RealSite realSite;
        private Dictionary<string, string> cache;

        public ProxySite(string url)
        {
            realSite = new RealSubjects.RealSite(url);
            cache = new Dictionary<string, string>();
        }

        public void Request(string user)
        {
            if (cache.ContainsKey(user))
            {
                Console.WriteLine($"Cached content for {user}: {cache[user]}");
            }
            else
            {
                realSite.Request(user);
                cache[user] = $"Cached content for {user}";
            }
        }
    }
}
