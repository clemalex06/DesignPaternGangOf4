using System;
namespace Visitor
{
    public abstract class Company
    {
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Adress { get; protected set; }

        public Company(string name, string email, string adress)
        {
            Name = name;
            Email = email;
            Adress = adress;
        }

        public abstract bool AddSubsidiary(Company company);

        public abstract void AcceptVisitor(IVisitor visitor);
    }
}
