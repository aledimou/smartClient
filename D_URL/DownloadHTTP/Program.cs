
using System;
using System.IO;
using System.Net;

namespace DownloadHTTP
{
    class Program
    {
        static void Main(string[] args)
        {
            var URLdemand = new Storage();


            string link = "https://www.goals.gr/";

            string value = URLdemand.GetWebPage(link);

            URLdemand.ScrapeWebPage(link);//saves the script on a file

            Console.WriteLine(value);// Show the script on console
        }
    }
}
