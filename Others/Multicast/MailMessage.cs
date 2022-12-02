namespace Multicast
{
    public class MailMessage : AbstractMessage
    {
        public string MailAddressSender { get; set; }

        public MailMessage(string content, string mailAddressSender)
            :base(content)
        {
            MailAddressSender = mailAddressSender;
        }
    }
}
