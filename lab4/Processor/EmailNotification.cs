using Lab4.Processor

namespace Lab4
{
    public class EmailNotification : iNotification
    {
        private string _adminEmail;

        public void Send(string title, string message)
        {
            var logMessage = $"Email '${title}' to '${_adminEmail} content '${message}'";
        }

        public EmailNotification(string adminEmail)
        {
        }
    }
}