
using System;
using System.IO;
using System.Net;


namespace DownloadHTTP
{
    class Storage : Install
    {
        public string ScrapeWebPage(string url)
        {
            string reply = GetWebPage(url);

            File.WriteAllText(@"C:\Users\user\Documents\myTestFolder\MyTXT", reply);

            return reply;
        }
    }
}
