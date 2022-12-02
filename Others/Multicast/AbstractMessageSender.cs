using System.Collections.Generic;
namespace Multicast
{
    public abstract class AbstractMessageSender<TMessage, TRecipient>
        where TMessage : AbstractMessage
        where TRecipient : IMessageRecipient<TMessage>
    {
        protected IList<TRecipient> Recipients = new List<TRecipient>();

        public void AddRecipient(TRecipient recipient)
        {
            Recipients.Add(recipient);
        }

        public void SendMultipleRecipients(TMessage message)
        {
            foreach (var consumer in Recipients)
                consumer.Receive(message);
        }
    }
}
