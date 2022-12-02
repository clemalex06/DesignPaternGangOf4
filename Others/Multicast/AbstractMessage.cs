namespace Multicast
{
    public abstract class AbstractMessage
    {
        public string Content { get; protected set; }

        public AbstractMessage(string content)
        {
            this.Content = content;
        }
    }
}
