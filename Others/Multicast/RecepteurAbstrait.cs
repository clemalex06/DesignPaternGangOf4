using System;
namespace Multicast
{
    public interface RecepteurAbstrait<TMessage>
        where TMessage:MessageAbstrait
    {
        void recoit(TMessage message);
    }
}
