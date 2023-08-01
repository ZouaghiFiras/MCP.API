namespace CED.Data.Entities
{
    public class PurchaseBacklogValidationLine
    {
        public Guid PvlId { get; set; }

        public byte[] PvlTimeStamp { get; set; } = null!;

        public Guid PvlPurchaseBacklogValidationId { get; set; }

        public int PvlLineNumber { get; set; }

        public short PvlRuleType { get; set; }

        public bool PvlIsValid { get; set; }

        public string? PvlMessage { get; set; }

        public DateTime PvlCreatedDate { get; set; }

        public string? PvlCreatedBy { get; set; }

        public DateTime PvlLastModifiedDate { get; set; }

        public string? PvlLastModifiedBy { get; set; }

        public virtual PurchaseBacklogValidation PvlPurchaseBacklogValidation { get; set; } = null!;
    }
}