namespace CED.Data.Entities
{
    public class CostType
    {
        public Guid CtpId { get; set; }

        public byte[] CtpTimeStamp { get; set; } = null!;

        public string CtpCode { get; set; } = null!;

        public string? CtpShortName { get; set; }

        public string CtpLongName { get; set; } = null!;

        public bool CtpInactive { get; set; }

        public Guid? CtpLocalizableEntryId { get; set; }

        public DateTime CtpCreatedDate { get; set; }

        public string? CtpCreatedBy { get; set; }

        public DateTime CtpLastModifiedDate { get; set; }

        public string? CtpLastModifiedBy { get; set; }

        public virtual ICollection<Claim> Claims { get; } = new List<Claim>();

        public virtual LocalizableEntry? CtpLocalizableEntry { get; set; }

        public virtual ICollection<OvsPayment> OvsPayments { get; } = new List<OvsPayment>();

        public virtual ICollection<Retention> Retentions { get; } = new List<Retention>();
    }
}