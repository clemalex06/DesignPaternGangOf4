using System;
namespace Composite
{
    /*
     * Composite's Concept :
     * Lets you compose objects into 
     * tree structures and then work 
     * with these structures as if they were individual objects.
     */
    public static class CompositeMain
    {
        public static void Main()
        {
            var company1 = new CompanyWithoutSubsidiary();
            company1.AddCar();
            var company2 = new CompanyWithoutSubsidiary();
            company2.AddCar();
            company2.AddCar();

            var parentCompany = new ParentCompany();
            parentCompany.AddCar();
            parentCompany.AddSubsidiaryCompany(company1);
            parentCompany.AddSubsidiaryCompany(company2);
            Console.WriteLine($"Total Compute Maintenance Cost" +
                $" from Parent Company : " +
                $"{parentCompany.ComputeMaintenanceCost()}");

        }
    }
}
