using System;
using System.Collections.Generic;
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
        }

    }
}
