using System;
namespace Bridge
{
    public class InsuranceNumberFormFrance : InsuranceNumberForm
    {
        public InsuranceNumberFormFrance(IFormImplementation implantation)
            : base(implantation)
        {
        }

        protected override bool ValidateInputArea(string insuranceNumber)
        {
            return insuranceNumber.Length == 7;
        }
    }
}
