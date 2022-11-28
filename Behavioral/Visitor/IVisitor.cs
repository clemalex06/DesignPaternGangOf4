namespace Visitor
{
    public interface IVisitor
    {
        void Visit(SubsidiaryLessCompany company);

        void Visit(ParentCompany company);
    }
}
