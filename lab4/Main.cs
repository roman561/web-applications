using Lab4.Interfaces
using Lab4.Processor

namespace Lab4
{
    public class Main
    {
        private const string LOGIN = "login";
        private const string EMAIL = "name@email.com";
        private const string SLACK_API_KEY = "key";

        public void Run()
        {
            var message = "Welcome!";

            var emailNotification = new EmailNotification(EMAIL);
            SendMessage(emailNotification, "title", message);

            var slack = new Slack();
            var slackAdapter = new SlackAdapter(slack);
            slackAdapter.Authorize(LOGIN, SLACK_API_KEY);
            slackAdapter.SetChatId("chatID");
            SendMessage(slackAdapter, "content", message);

            var sms = new Sms();
            var smsAdapter = new SmsAdapter(sms);
            smsAdapter.SetSenderNumber("#Number");
            smsAdapter.SetRecipientNumber("#Number");
            SendMessage(smsAdapter, "content", message);
        }

        private void SendMessage(iNotification notification, string title, string message)
        {
            notification.Send(title, message);
        }
    }
}