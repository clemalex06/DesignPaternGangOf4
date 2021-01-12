using System;
namespace Multicast
{
    public class MessageCommercial : MessageAbstrait
    {
        public string contenu { get; protected set; }

        public MessageCommercial(string contenu)
        {
            this.contenu = contenu;
        }
    }
}
