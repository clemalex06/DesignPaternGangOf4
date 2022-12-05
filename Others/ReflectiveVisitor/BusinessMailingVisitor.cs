using System;
namespace ReflectiveVisitor
{
    public class BusinessMailingVisitor : Visitor, IVisitor
    {
        public void Visit(SubsidiaryLessCompany company)
        {
            Console.WriteLine($"Send an email to {company.Name}" +
                $" Address : {company.Address}, {company.Email}" +
                $" Commercial proposal for your company");
        }

        public void Visit(ParentCompany company)
        {
            Console.WriteLine($"Send an email to {company.Name}" +
                $" Address : {company.Address}, {company.Email}" +
                $" Commercial proposal for your group");
            Console.WriteLine($"Printing a letter to {company.Name}" +
                $" Address : {company.Address}, {company.Email}" +
                $" Commercial proposal for your group");
            foreach (var subsidiary in company.Subsidiaries)
                StartVisit(subsidiary);
        }
    }
}
