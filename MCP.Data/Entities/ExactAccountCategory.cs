namespace CED.Data.Entities
{
    public class ExactAccountCategory
    {
        public Guid EacId { get; set; }

        public string EacCode { get; set; } = null!;

        public string? EacDescription { get; set; }

        public bool EacInactive { get; set; }

        public DateTime EacCreatedDate { get; set; }

        public string? EacCreatedBy { get; set; }

        public DateTime EacLastModifiedDate { get; set; }

        public string? EacLastModifiedBy { get; set; }

        public byte[] EacTimeStamp { get; set; } = null!;

        public virtual ICollection<Creditor> Creditors { get; } = new List<Creditor>();

        public virtual ICollection<Debtor> Debtors { get; } = new List<Debtor>();
    }
}