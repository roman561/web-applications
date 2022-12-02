using Lab3.Processor

namespace Lab3
{
    public class Facebook : iManager
    {
        private bool _isAuthorized;

        public bool Authorize(string login, string password)
        {
            _isAuthorized = !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password);
            return _isAuthorized;
        }

        public string PostMessage(string message)
        {
            if (!_isAuthorized) throw new Exception("Not authorized");
            return $"Are you sure you want to post on Facebook: {message}";
        }
    }
}