using SneakerWatcher.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SneakerWatcher.Services
{
    public class GetPageUsingUrl
    {
        string _url;

        public GetPageUsingUrl(string url)
        {
            _url = url;
        }

        public void GetPage()
        {
            WebClient client = new WebClient();
            string s = client.DownloadString(_url);

            using (Stream stream = client.OpenRead(_url))
            {
                StreamReader sr = new StreamReader(stream);
                Console.WriteLine(sr.ReadToEnd());
                stream.Close();
            }

            Console.WriteLine(s.ToString());
            
        }
    }
}
