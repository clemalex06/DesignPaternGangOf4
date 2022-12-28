namespace Facade
{
    public class DocumentManagementComponent : IDocumentManagement
    {

        public string Document(int index)
        {
            return $"Document numero {index}";
        }
    }
}
