namespace Visitor
{
    public class SubsidiaryLessCompany : Company
    {
        public SubsidiaryLessCompany(string nom, string email, string adresse)
            : base(nom, email, adresse)
        {
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override bool AddSubsidiary(Company company)
        {
            return false;
        }
    }
}
