using Lab4.Processor

namespace Lab4
{
    public class SmsAdapter: iNotification
    {
        private Sms _sms;
        private string _senderNumber;
        private string _recipientNumber;

        public void Send(string title, string message)
        {
            if (string.IsNullOrEmpty(_senderPhoneNumber)) throw new ArgumentNullException("Sender number is required");
            if (string.IsNullOrEmpty(_recipientPhoneNumber)) throw new ArgumentNullException("Recipient number is required");

            _sms.SendSms(_senderPhoneNumber, _recipientPhoneNumber, message);
        }

        public void SetSenderNumber(string number)
        {
        }

        public void SetRecipientNumber(string number)
        {
        }

        public SmsAdapter(Sms _sms)
        {
        }
    }
}
