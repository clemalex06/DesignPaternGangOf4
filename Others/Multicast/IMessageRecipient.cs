namespace Multicast
{
    public interface IMessageRecipient<TMessage>
        where TMessage : AbstractMessage
    {
        void Receive(TMessage message);
    }
}
