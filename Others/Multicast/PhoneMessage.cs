using System.Collections.Generic;
namespace Multicast
{
    public class PhoneMessage : AbstractMessage
    {
        public string PhoneNumberSender { get; set; }
        public PhoneMessage(string content, string phoneNumberSender)
            : base(content)
        {
            PhoneNumberSender = phoneNumberSender;
        }
    }
}
