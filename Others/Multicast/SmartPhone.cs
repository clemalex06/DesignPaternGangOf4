using System;
namespace Multicast
{
    public class SmartPhone : AbstractPhoneRecipient, IMailRecipient
    {
        protected string EmailAddress;

        public SmartPhone(string modelName, string phoneNumber, string emailAddress)
            : base(modelName, phoneNumber)
        {
            EmailAddress = emailAddress;
        }

        public void Receive(MailMessage message)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Email Message on smartphone");
            Console.WriteLine($"Recipient => ModelName : '{ModelName}', email : '{EmailAddress}'");

            Console.WriteLine($"Sender : '{message.MailAddressSender}'");
            Console.WriteLine($"Content : '{message.Content}' ");
            Console.WriteLine("------------------------");
        }
    }
}
