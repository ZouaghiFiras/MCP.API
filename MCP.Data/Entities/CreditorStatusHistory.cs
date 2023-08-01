namespace CED.Data.Entities
{
    public class CreditorStatusHistory
    {
        public Guid CdshId { get; set; }

        public byte[] CdshTimeStamp { get; set; } = null!;

        public Guid CdshCreditorId { get; set; }

        public Guid CdshCreditorStatusId { get; set; }

        public Guid? CdshEmployeeId { get; set; }

        public DateTime CdshStartDate { get; set; }

        public string? CdshStatusChangeReason { get; set; }

        public short CdshStatusSource { get; set; }

        public DateTime CdshCreatedDate { get; set; }

        public string? CdshCreatedBy { get; set; }

        public DateTime CdshLastModifiedDate { get; set; }

        public string? CdshLastModifiedBy { get; set; }

        public virtual Creditor CdshCreditor { get; set; } = null!;

        public virtual CreditorStatus CdshCreditorStatus { get; set; } = null!;

        public virtual Employee? CdshEmployee { get; set; }
    }
}