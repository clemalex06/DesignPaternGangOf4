using System;
namespace Bridge
{
    public class InsuranceNumberFormSpain : InsuranceNumberForm
    {
        public InsuranceNumberFormSpain(IFormImplementation implantation)
            : base(implantation)
        {
        }

        protected override bool ValidateInputArea(string insuranceNumber)
        {
            return insuranceNumber.Length == 5;
        }
    }
}
