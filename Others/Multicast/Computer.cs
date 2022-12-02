using System;
namespace Multicast
{
    public class Computer : IMailRecipient
    {
        private string ModelName;
        private string EmailAddress;

        public Computer(string modelName, string emailAddress)
        {
            ModelName = modelName;
            EmailAddress = emailAddress;
        }

        public void Receive(MailMessage message)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Email Message on Computer");
            Console.WriteLine($"Recipient => ModelName : '{ModelName}', email : '{EmailAddress}'");

            Console.WriteLine($"Sender : '{message.MailAddressSender}'");
            Console.WriteLine($"Content :'{message.Content}'.");
            Console.WriteLine("------------------------");
        }
    }
}
