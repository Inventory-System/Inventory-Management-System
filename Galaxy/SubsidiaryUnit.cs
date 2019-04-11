namespace Galaxy
{
    public class SubsidiaryUnit : BaseClass
    {
        public virtual string SubsidiaryUnitName { set; get; }
        public virtual decimal Coefficient { get; set; }
        public virtual Measurement measurement { get; set; }
    }
}