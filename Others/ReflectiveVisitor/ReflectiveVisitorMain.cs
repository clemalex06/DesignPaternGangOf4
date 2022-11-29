using System;

namespace ReflectiveVisitor
{
    /*
     * ### Reflective Visitor's Concept :
     * It's a design pattern which implements  Visitor + Composite
     * 
     */
    public static class ReflectiveVisitorMain
    {
        public static void Main()
        {
            var company1 = new SubsidiaryLessCompany("company1",
                "info@company1.com", "company1 street");
            var company2 = new SubsidiaryLessCompany("company2",
                "info@company2.com", "company2 street");
            var company3 = new SubsidiaryLessCompany("company3",
                "info@company3.com", "company3 street");

            var group1 = new ParentCompany("group1", "info@group1.com",
                "group1 street");
            var group2 = new ParentCompany("group2", "info@group2.com",
                "group2 street");

            group1.AddSubsidiary(company1);
            group1.AddSubsidiary(company2);
            group2.AddSubsidiary(group1);
            group2.AddSubsidiary(company3);

            new BusinessMailingVisitor().StartVisit(group2);
        }
    }
}
