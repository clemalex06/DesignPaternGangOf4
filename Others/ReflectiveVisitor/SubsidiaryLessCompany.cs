using System;
namespace ReflectiveVisitor
{
    public class SubsidiaryLessCompany : Company
    {
        public SubsidiaryLessCompany(string name, string email,
           string address ):base(name,email,address)
        {
        }

        public override bool AddSubsidiary(Company company)
        {
            return false;
        }
    }
}
