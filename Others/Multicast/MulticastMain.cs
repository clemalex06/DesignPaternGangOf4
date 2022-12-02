using System;
using System.Collections.Generic;

namespace Multicast
{
    /*
     * ### MultiCast delegate 's Concept :
     * The multicast delegate pattern is a behavioral pattern that’s a variation on the delegate pattern. 
     * It allows you to create one-to-many delegate relationships, 
     * instead of one-to-one relationships in a simple delegate.
     */
    public static class MultiCastMain
    {
        public static void Main()
        {
            var messageServer = new MessageServer("0808", "server@email.com");
            var smartphone1 = new SmartPhone("iPhone", "0102", "iPhone@email.com");
            var smartphone2 = new SmartPhone("Samsung", "0304", "Samsung@email.com");
            var mobilePhone = new MobilePhone("Nokia", "0506");
            var mobilePhones = new List<IPhoneRecipient> { smartphone1, smartphone2, mobilePhone };
            messageServer.RegisterPhoneRecipients(mobilePhones);


            var computer = new Computer("MacBookAir", "macBook@email.com");
            var computers = new List<IMailRecipient> { smartphone1, smartphone2, computer };
            messageServer.RegisterMailRecipients(computers);

            var content = "This is the content of the message";

            messageServer.SendMessages(content);
        }
    }
}
