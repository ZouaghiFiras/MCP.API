namespace CED.Data.Entities
{
    public class Office
    {
        public Guid OfId { get; set; }

        public byte[] OfTimeStamp { get; set; } = null!;

        public string OfName { get; set; } = null!;

        public Guid OfLegalEntityId { get; set; }

        public Guid? OfAddressId { get; set; }

        public DateTime OfCreatedDate { get; set; }

        public string? OfCreatedBy { get; set; }

        public DateTime OfLastModifiedDate { get; set; }

        public string? OfLastModifiedBy { get; set; }

        public virtual ICollection<DepartmentOffice> DepartmentOffices { get; } = new List<DepartmentOffice>();

        public virtual Address? OfAddress { get; set; }

        public virtual LegalEntity OfLegalEntity { get; set; } = null!;
    }
}