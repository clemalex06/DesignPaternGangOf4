using System.Collections.Generic;

namespace Visitor
{
    public class ParentCompany : Company
    {
        protected IList<Company> Subsidiaries =
            new List<Company>();

        public ParentCompany(string name, string email, string adresse)
            :base(name, email, adresse)
        {
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var soc in Subsidiaries)
                soc.AcceptVisitor(visitor);
        }

        public override bool AddSubsidiary(Company company)
        {
            Subsidiaries.Add(company);
            return true;
        }
    }
}
