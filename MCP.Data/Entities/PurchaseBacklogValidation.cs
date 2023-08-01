namespace CED.Data.Entities
{
    public class PurchaseBacklogValidation
    {
        public Guid PbvId { get; set; }

        public byte[] PbvTimeStamp { get; set; } = null!;

        public Guid PbvPurchaseBacklogId { get; set; }

        public bool PbvIsValid { get; set; }

        public DateTime PbvCreatedDate { get; set; }

        public string? PbvCreatedBy { get; set; }

        public DateTime PbvLastModifiedDate { get; set; }

        public string? PbvLastModifiedBy { get; set; }

        public virtual PurchaseBacklog PbvPurchaseBacklog { get; set; } = null!;

        public virtual ICollection<PurchaseBacklogValidationLine> PurchaseBacklogValidationLines { get; } =
            new List<PurchaseBacklogValidationLine>();
    }
}