using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.RealSubjects
{
    public class RealSite : Subjects.ISite
    {
        private string content;

        public RealSite(string url)
        {
            content = $"Content of {url}";
        }

        public void Request(string user)
        {
            Console.WriteLine($"Request from {user}: {content}");
        }
    }
}
