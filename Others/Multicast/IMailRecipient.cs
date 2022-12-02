using System;
namespace Multicast
{
    public interface IMailRecipient :
        IMessageRecipient<MailMessage>
    {
    }
}
