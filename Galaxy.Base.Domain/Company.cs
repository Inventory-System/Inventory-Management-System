namespace Galaxy.Base.Domain
{
   public class Company:Party
    {
        public virtual int CompanyID { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string Industry { get; set; }
        public virtual int FaxNumber { get; set; }
        public virtual string Website { get; set; }
    }
}
