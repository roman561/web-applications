using Lab3.Processor

namespace Lab3
{
    public class LinkedIn : iManager
    {
        private bool _isAuthorized;

        public bool Authorize(string email, string password)
        {
            _isAuthorized = !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password);
            return _isAuthorized;
        }

        public string PostMessage(string message)
        {
            if (!_isAuthorized) throw new Exception("Not authorized");
            return $"Are you sure you want to post on LinkedIn: {message}";
        }
    }
}
