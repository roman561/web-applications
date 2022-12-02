using Lab6.Interfaces

namespace Lab6
{
    public class Client
    {
        public void ProcessDownload(iDownloader downloader, string path)
        {
            var file = downloader.Download(path);
        }
    }
}