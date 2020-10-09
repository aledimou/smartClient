using System;
using System.IO;
using System.Net;


namespace DownloadHTTP
{

     class Install : ISource
    {

         
        public override string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }

        public override string ScrapeWebPage(string url)
        {

            return GetWebPage(url);

        }


    }
}


