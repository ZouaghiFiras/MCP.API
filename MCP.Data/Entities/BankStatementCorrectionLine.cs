namespace CED.Data.Entities
{
    public class BankStatementCorrectionLine
    {
        public Guid BclId { get; set; }

        public byte[] BclTimeStamp { get; set; } = null!;

        public int BclLineNumber { get; set; }

        public Guid BclBankStatementCorrectionId { get; set; }

        public Guid BclBankStatementReconciliationId { get; set; }

        public bool BclIsCredit { get; set; }

        public DateTime BclCreatedDate { get; set; }

        public string? BclCreatedBy { get; set; }

        public DateTime BclLastModifiedDate { get; set; }

        public string? BclLastModifiedBy { get; set; }

        public virtual BankStatementCorrection BclBankStatementCorrection { get; set; } = null!;

        public virtual BankStatementReconcilliation BclBankStatementReconciliation { get; set; } = null!;
    }
}