namespace CED.Data.Entities
{
    public class ProductLine
    {
        public Guid PlnId { get; set; }

        public byte[] PlnTimeStamp { get; set; } = null!;

        public string PlnCode { get; set; } = null!;

        public string? PlnShortName { get; set; }

        public string PlnLongName { get; set; } = null!;

        public bool PlnInactive { get; set; }

        public DateTime PlnCreatedDate { get; set; }

        public string? PlnCreatedBy { get; set; }

        public DateTime PlnLastModifiedDate { get; set; }

        public string? PlnLastModifiedBy { get; set; }

        public virtual ICollection<Department> Departments { get; } = new List<Department>();
    }
}