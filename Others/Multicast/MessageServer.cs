using System.Collections.Generic;
namespace Multicast
{
    public class MessageServer
    {
        private PhoneMessageSender PhoneMessageSender;
        
        private MailMessageSender MailMessageSender;

        private string PhoneNumber;
        
        private string EmailAddress;

        public MessageServer(string phoneNumber,string emailAddress)
        {
            PhoneMessageSender = new PhoneMessageSender();
            MailMessageSender = new MailMessageSender();
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;

        }

        public void RegisterPhoneRecipients(IList<IPhoneRecipient> recipients)
        {
            foreach (var recipient in recipients)
            {
                PhoneMessageSender.AddRecipient(recipient);
            }
        }

        public void RegisterMailRecipients(IList<IMailRecipient> recipients)
        {
            foreach (var recipient in recipients)
            {
                MailMessageSender.AddRecipient(recipient);
            }
        }

        public void SendMessages(string content)
        {
            SendPhoneMessages(content);
            SendMailMessages(content);
        }

        private void SendPhoneMessages(string content)
        {
            var message = new PhoneMessage(content, PhoneNumber);
            PhoneMessageSender.SendMultipleRecipients(message);
        }

        private void SendMailMessages(string content)
        {
            var message = new MailMessage(content, EmailAddress);
            MailMessageSender.SendMultipleRecipients(message);
        }
    }
}
