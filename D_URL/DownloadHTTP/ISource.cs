namespace DownloadHTTP
{
    abstract class ISource
    {

        public abstract string GetWebPage(string url);
        public abstract string ScrapeWebPage(string url);
   
    }
}
