namespace CED.Data.Entities
{
    public class BankStatementStatusHistory
    {
        public Guid BshId { get; set; }

        public byte[] BshTimeStamp { get; set; } = null!;

        public Guid BshBankStatementId { get; set; }

        public Guid BshBankStatementStatusId { get; set; }

        public DateTime BshStartDate { get; set; }

        public string? BshStatusChangeReason { get; set; }

        public DateTime BshCreatedDate { get; set; }

        public string? BshCreatedBy { get; set; }

        public DateTime BshLastModifiedDate { get; set; }

        public string? BshLastModifiedBy { get; set; }

        public virtual BankStatement BshBankStatement { get; set; } = null!;

        public virtual BankStatementStatus BshBankStatementStatus { get; set; } = null!;
    }
}