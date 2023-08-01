namespace CED.Data.Entities
{
    public class CreditTransferStatusHistory
    {
        public Guid CshId { get; set; }

        public byte[] CshTimeStamp { get; set; } = null!;

        public Guid CshCreditTransferId { get; set; }

        public Guid CshCreditTransferStatusId { get; set; }

        public DateTime CshStartDate { get; set; }

        public DateTime CshCreatedDate { get; set; }

        public string? CshCreatedBy { get; set; }

        public DateTime CshLastModifiedDate { get; set; }

        public string? CshLastModifiedBy { get; set; }

        public virtual CreditTransfer CshCreditTransfer { get; set; } = null!;

        public virtual CreditTransferStatus CshCreditTransferStatus { get; set; } = null!;
    }
}