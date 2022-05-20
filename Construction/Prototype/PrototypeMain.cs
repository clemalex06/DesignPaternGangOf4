using System;

namespace Prototype
{
    /*
     * Prototype's Concept :
     * Creates duplicate object while keeping performance in mind. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
     * 
     */
    public static class PrototypeMain
    {
        public static void Main()
        {
            EmptyDocumentList emptyDocumentList = EmptyDocumentList.Instance();

            emptyDocumentList.Add(new PurchaseOrderDocument());
            emptyDocumentList.Add(new SessionCertificateDocument());
            emptyDocumentList.Add(new ApplicationForRegistrationDocument());

            CustomerDocumentList customerDocumentList1 = new CustomerDocumentList("Martin");
            CustomerDocumentList customerDocumentList2 = new CustomerDocumentList("Durant");

            customerDocumentList1.Display();
            customerDocumentList2.Display();
        }
    }
}
