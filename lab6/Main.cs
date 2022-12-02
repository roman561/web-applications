using Lab6.Interfaces
using Lab6.Processor

namespace Lab6
{
    public class Main
    {
        public void Run()
        {
            iDownloader downloader = new SimpleDownloader(downloader);
            iDownloader cachedDownloader = new CachedDownloader(downloader);

            var client = new Client();
            client.ProcessDownload(cachedDownloader, "https://site.com/file1.csv");
            client.ProcessDownload(cachedDownloader, "https://site.com/file2.csv");
            client.ProcessDownload(cachedDownloader, "https://site.com/file3.csv");
        }
    }
}