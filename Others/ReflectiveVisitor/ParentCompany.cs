using System.Collections.Generic;
namespace ReflectiveVisitor
{
    public class ParentCompany : Company
    {
        public IList<Company> Subsidiaries { get; protected set; }

        public ParentCompany(string name, string email, string adress)
            : base(name, email, adress)
        {
            Subsidiaries = new List<Company>();
        }

        public override bool AddSubsidiary(Company company)
        {
            Subsidiaries.Add(company);
            return true;
        }
    }
}
