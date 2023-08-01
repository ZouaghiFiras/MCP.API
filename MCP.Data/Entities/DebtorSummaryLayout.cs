namespace CED.Data.Entities
{
    public class DebtorSummaryLayout
    {
        public Guid DbslId { get; set; }

        public byte[] DbslTimeStamp { get; set; } = null!;

        public Guid? DbslFrontPageLayout { get; set; }

        public short? DbslFrontPageFormat { get; set; }

        public Guid? DbslSpecificationLayout { get; set; }

        public short? DbslSpecificationFormat { get; set; }

        public short? DbslEmailBody { get; set; }

        public string? DbslSentMethod { get; set; }

        public DateTime? DbslStartDate { get; set; }

        public DateTime? DbslEndDate { get; set; }

        public Guid DbslDebtorId { get; set; }

        public DateTime DbslCreatedDate { get; set; }

        public string? DbslCreatedBy { get; set; }

        public DateTime DbslLastModifiedDate { get; set; }

        public string? DbslLastModifiedBy { get; set; }

        public virtual Debtor DbslDebtor { get; set; } = null!;
    }
}