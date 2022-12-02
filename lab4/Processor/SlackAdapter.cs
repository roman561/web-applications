using Lab4.Processor

namespace Lab4
{
    public class SlackAdapter: iNotification
    {
        private Slack _slack;
        private string _chatID;

        public void Send(string title, string message)
        {
            _slack.SendMessage(_chatID, message);
        }

        public void Authorize(string login, string apiKey)
        {
        }

        public void SetChatId(string chatID)
        {
        }

        public SlackAdapter(Slack _slack)
        {
        }
    }
}
