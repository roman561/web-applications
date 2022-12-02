using Lab6.Interfaces;

namespace Lab6
{
    public class CachedDownloader : iDownloader
    {
        private iDownloader _downloader;
        private Dictionary<string, object> _cache;

        public CachedDownloader(iDownloader downloader)
        {
            _downloader = downloader;
            _cache = new Dictionary<string, object>();
        }

        public object Download(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("required");

            if (_cache.ContainsKey(path)) return _cache[path];
            var file = _downloader.Download(path);
            _cache.Add(path, file);
            return file;
        }
    }
}