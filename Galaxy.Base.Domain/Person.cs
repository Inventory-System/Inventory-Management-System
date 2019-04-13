namespace Galaxy.Base.Domain
{
    public class Person : Party
    {
        public virtual int NationalIdentityNumber { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
    }
}
