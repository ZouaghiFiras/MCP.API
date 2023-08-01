namespace CED.Data.Entities
{
    public class BankStatementCorrection
    {
        public Guid BscId { get; set; }

        public byte[] BscTimeStamp { get; set; } = null!;

        public bool BscIsFinalized { get; set; }

        public string BscCorrectionReason { get; set; } = null!;

        public DateTime BscCreatedDate { get; set; }

        public string? BscCreatedBy { get; set; }

        public DateTime BscLastModifiedDate { get; set; }

        public string? BscLastModifiedBy { get; set; }

        public virtual ICollection<BankStatementCorrectionLine> BankStatementCorrectionLines { get; } =
            new List<BankStatementCorrectionLine>();

        public virtual BankStatementReconcilliation Bsc { get; set; } = null!;
    }
}