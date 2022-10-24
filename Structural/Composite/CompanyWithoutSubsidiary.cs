using System;
namespace Composite
{
    public class CompanyWithoutSubsidiary : Company
    {
        public override bool AddSubsidiaryCompany(Company company)
        {
            return false;
        }

        public override double ComputeMaintenanceCost()
        {
            return NumberOfCars * CountUnitVehicule;
        }
    }
}
