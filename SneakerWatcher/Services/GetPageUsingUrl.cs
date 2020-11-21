using System;
using System.IO;
using System.Net;

namespace SneakerWatcher.Services
{
    public class GetPageUsingUrl
    {
        readonly string _url;

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
