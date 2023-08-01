namespace CED.Data.Entities
{
    public class SalesCollection
    {
        public Guid SacId { get; set; }

        public byte[] SacTimeStamp { get; set; } = null!;

        public string SacCollectionNumber { get; set; } = null!;

        public DateTime SacCollectionDate { get; set; }

        public Guid SacRecipientDebtorId { get; set; }

        public string? SacRecipientEmail { get; set; }

        public DateTime? SacDueDate { get; set; }

        public DateTime SacCreatedDate { get; set; }

        public string? SacCreatedBy { get; set; }

        public DateTime SacLastModifiedDate { get; set; }

        public string? SacLastModifiedBy { get; set; }

        public Guid? SacCurrentStatusHistoryId { get; set; }

        public DateTime? SacCurrentStatusHistoryStartDate { get; set; }

        public string? SacCurrentStatusCode { get; set; }

        public virtual Debtor SacRecipientDebtor { get; set; } = null!;

        public virtual ICollection<SalesCollectionAttachment> SalesCollectionAttachments { get; } =
            new List<SalesCollectionAttachment>();

        public virtual ICollection<SalesCollectionDebtor> SalesCollectionDebtors { get; } =
            new List<SalesCollectionDebtor>();

        public virtual ICollection<SalesCollectionLine> SalesCollectionLines { get; } = new List<SalesCollectionLine>();

        public virtual ICollection<SalesCollectionNote> SalesCollectionNotes { get; } = new List<SalesCollectionNote>();

        public virtual ICollection<SalesCollectionStatusHistory> SalesCollectionStatusHistories { get; } =
            new List<SalesCollectionStatusHistory>();
    }
}