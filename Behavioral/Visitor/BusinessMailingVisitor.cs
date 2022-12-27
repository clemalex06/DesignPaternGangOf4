using System;
namespace Visitor
{
    public class BusinessMailingVisitor : IVisitor
    {
        public void Visit(SubsidiaryLessCompany company)
        {
            Console.WriteLine($"Send an email to { company.Name}" +
                $" Address : {company.Adress}, {company.Email}" +
                $" Commercial proposal for your company");
        }

        public void Visit(ParentCompany company)
        {
            Console.WriteLine($"Send an email to {company.Name}" +
                $" Address : {company.Adress}, {company.Email}" +
                $" Commercial proposal for your group");
            Console.WriteLine($"Printing a letter to { company.Name}" +
                $" Address : {company.Adress}, {company.Email}" +
                $" Commercial proposal for your group");

        }
    }
}
