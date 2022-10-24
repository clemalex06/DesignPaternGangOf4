using System;
namespace Bridge
{
    public abstract class InsuranceNumberForm
    {
        protected string Content;

        protected IFormImplementation Implementation;

        public InsuranceNumberForm(IFormImplementation implantation)
        {
            this.Implementation = implantation;
        }

        public void Display()
        {
            Implementation.WriteText("Insurance Number: ");
        }

        public void GenerateNumber()
        {
            Implementation.WriteText("Request a new Insurance Number");
            Implementation.WriteText($"Insurance Number : {Content}");

        }

        public bool ManageInput()
        {
            Content = Implementation.ManageInputArea();
            return ValidateInputArea(Content);
        }

        protected abstract bool ValidateInputArea(string insuranceNumber);
    }
}
