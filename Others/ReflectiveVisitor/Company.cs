namespace ReflectiveVisitor
{
    public abstract class Company : IVisitable
    {
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Address { get; protected set; }

        public Company(string name, string email, string address)
        {
            Name = name;
            Email = email;
            Address = address;
        }

        public abstract bool AddSubsidiary(Company company);
    }
}
