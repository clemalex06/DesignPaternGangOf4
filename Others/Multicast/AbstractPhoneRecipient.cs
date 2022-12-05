using System;
namespace Multicast
{
    public abstract class AbstractPhoneRecipient : IPhoneRecipient
    {
        protected string ModelName;
        protected string PhoneNumber;

        public AbstractPhoneRecipient(string modelName, string phoneNumber)
        {
            ModelName = modelName;
            PhoneNumber = phoneNumber;
        }

        public void Receive(PhoneMessage message)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Phone Message");
            Console.WriteLine($"Recipient => ModelName : '{ModelName}', PhoneNumber : '{PhoneNumber}'");
            
            Console.WriteLine($"Sender Phone Number: '{message.PhoneNumberSender}'");
            Console.WriteLine($"Content : '{message.Content}' ");
            Console.WriteLine("------------------------");
        }
    }
}
