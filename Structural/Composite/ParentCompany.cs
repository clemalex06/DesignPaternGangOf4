using System.Collections.Generic;
namespace Composite
{
    public class ParentCompany : Company
    {

        public IList<Company> companies = new List<Company>();

        public override bool AddSubsidiaryCompany(Company company)
        {
            companies.Add(company);
            return true;
        }

        public override double ComputeMaintenanceCost()
        {
            double count = 0;
            foreach (var p in companies)
                count += p.ComputeMaintenanceCost();
            return count + NumberOfCars * CountUnitVehicule;
        }
    }
}
