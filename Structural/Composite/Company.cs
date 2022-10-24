using System;
namespace Composite
{
    public abstract class Company
    {
        protected static double CountUnitVehicule = 5;
        protected int NumberOfCars;

        public void AddCar()
        {
            NumberOfCars += 1;
        }

        public abstract double ComputeMaintenanceCost();

        public abstract bool AddSubsidiaryCompany(Company company);
    }
}
