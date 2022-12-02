namespace Lab4
{
    public class Slack
    {
        private bool _isAuthorized;

        public void Authorize(string login, string apiKey)
        {
            _isAuthorized = !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(apiKey);
        }

        public void SendMessage(string chatID, string message)
        {
            if (!_isAuthorized) throw new Exception("Not Authorized");

        }
    }
}
