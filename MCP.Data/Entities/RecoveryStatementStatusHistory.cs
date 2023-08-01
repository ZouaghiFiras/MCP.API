namespace CED.Data.Entities
{
    public class RecoveryStatementStatusHistory
    {
        public Guid RshId { get; set; }

        public byte[] RshTimeStamp { get; set; } = null!;

        public Guid RshRecoveryStatementId { get; set; }

        public Guid RshRecoveryStatementStatusId { get; set; }

        public DateTime RshStartDate { get; set; }

        public string? RshStatusChangeReason { get; set; }

        public DateTime RshCreatedDate { get; set; }

        public string? RshCreatedBy { get; set; }

        public DateTime RshLastModifiedDate { get; set; }

        public string? RshLastModifiedBy { get; set; }

        public virtual RecoveryStatement RshRecoveryStatement { get; set; } = null!;

        public virtual RecoveryStatementStatus RshRecoveryStatementStatus { get; set; } = null!;
    }
}